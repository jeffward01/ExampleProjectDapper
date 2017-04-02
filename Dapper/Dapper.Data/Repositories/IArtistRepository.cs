using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface IArtistRepository
    {
        Artist GetArtistById(int artistId);
        List<Artist> GetAllArtists();
        bool DeleteArtist(Artist artist);
        List<Artist> CreateArtist(int artistId);
        Artist EditArtist(Artist artist);
    }
}