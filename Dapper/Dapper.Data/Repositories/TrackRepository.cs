using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Data.Infrastructure;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public class TrackRepository : ITrackRepository
    {
        public Track GetTrackById(int TrackId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Tracks.Find(TrackId);
            }
        }

        public List<Track> GetAllTracks()
        {
            using (var context = new SampleProjectContext())
            {
                return context.Tracks.ToList();
            }
        }

        public bool DeleteTrack(Track Track)
        {
            using (var context = new SampleProjectContext())
            {
                context.Tracks.Attach(Track);
                context.Tracks.Remove(Track);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public List<Track> CreateTrack(int TrackId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Tracks.ToList();
            }
        }

        public Track EditTrack(Track Track)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(Track).State = EntityState.Modified;
                context.SaveChanges();
                return context.Tracks.Find(Track.TrackId);
            }
        }
    }
}
