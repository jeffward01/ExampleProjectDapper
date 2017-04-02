using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface IRecordingRepository
    {
        Recording GetRecordingById(int RecordingId);
        List<Recording> GetAllRecordings();
        bool DeleteRecording(Recording Recording);
        List<Recording> CreateRecording(int RecordingId);
        Recording EditRecording(Recording Recording);
    }
}