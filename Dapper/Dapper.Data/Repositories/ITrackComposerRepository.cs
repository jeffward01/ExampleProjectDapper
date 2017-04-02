using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface ITrackComposerRepository
    {
        TrackComposer GetTrackComposerById(int TrackComposerId);
        List<TrackComposer> GetAllTrackComposers();
        bool DeleteTrackComposer(TrackComposer TrackComposer);
        List<TrackComposer> CreateTrackComposer(int TrackComposerId);
        TrackComposer EditTrackComposer(TrackComposer TrackComposer);
    }
}