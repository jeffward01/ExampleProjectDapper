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
    public class RecordingRepository : IRecordingRepository
    {
        public Recording GetRecordingById(int RecordingId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Recordings.Find(RecordingId);
            }
        }

        public List<Recording> GetAllRecordings()
        {
            using (var context = new SampleProjectContext())
            {
                return context.Recordings.ToList();
            }
        }

        public bool DeleteRecording(Recording Recording)
        {
            using (var context = new SampleProjectContext())
            {
                context.Recordings.Attach(Recording);
                context.Recordings.Remove(Recording);
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

        public List<Recording> CreateRecording(int RecordingId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Recordings.ToList();
            }
        }

        public Recording EditRecording(Recording Recording)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(Recording).State = EntityState.Modified;
                context.SaveChanges();
                return context.Recordings.Find(Recording.RecordingId);
            }
        }
    }
}
