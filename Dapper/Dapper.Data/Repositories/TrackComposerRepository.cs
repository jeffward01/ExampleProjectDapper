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
    public class TrackComposerRepository : ITrackComposerRepository
    {
        public TrackComposer GetTrackComposerById(int TrackComposerId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.TrackComposers.Find(TrackComposerId);
            }
        }

        public List<TrackComposer> GetAllTrackComposers()
        {
            using (var context = new SampleProjectContext())
            {
                return context.TrackComposers.ToList();
            }
        }

        public bool DeleteTrackComposer(TrackComposer TrackComposer)
        {
            using (var context = new SampleProjectContext())
            {
                context.TrackComposers.Attach(TrackComposer);
                context.TrackComposers.Remove(TrackComposer);
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

        public List<TrackComposer> CreateTrackComposer(int TrackComposerId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.TrackComposers.ToList();
            }
        }

        public TrackComposer EditTrackComposer(TrackComposer TrackComposer)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(TrackComposer).State = EntityState.Modified;
                context.SaveChanges();
                return context.TrackComposers.Find(TrackComposer.TrackComposerId);
            }
        }
    }
}
