using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface ITrackRepository
    {
        Track GetTrackById(int TrackId);
        List<Track> GetAllTracks();
        bool DeleteTrack(Track Track);
        List<Track> CreateTrack(int TrackId);
        Track EditTrack(Track Track);
    }
}