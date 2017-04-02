using Dapper.Data.Infrastructure;
using Dapper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Dapper.Data.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public Artist GetArtistById(int artistId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Artists.Find(artistId);
            }
        }

        public List<Artist> GetAllArtists()
        {
            using (var context = new SampleProjectContext())
            {
                return context.Artists.ToList();
            }
        }

        public bool DeleteArtist(Artist artist)
        {
            using (var context = new SampleProjectContext())
            {
                context.Artists.Attach(artist);
                context.Artists.Remove(artist);
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

        public List<Artist> CreateArtist(int artistId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Artists.ToList();
            }
        }

        public Artist EditArtist(Artist artist)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(artist).State = EntityState.Modified;
                context.SaveChanges();
                return context.Artists.Find(artist.ArtistId);
            }
        }
    }
}