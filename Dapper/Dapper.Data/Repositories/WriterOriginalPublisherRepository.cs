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
    public class WriterOriginalPublisherRepository : IWriterOriginalPublisherRepository
    {
        public WriterOriginalPublisher GetWriterOriginalPublisherById(int WriterOriginalPublisherId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.WriterOriginalPublishers.Find(WriterOriginalPublisherId);
            }
        }

        public List<WriterOriginalPublisher> GetAllWriterOriginalPublishers()
        {
            using (var context = new SampleProjectContext())
            {
                return context.WriterOriginalPublishers.ToList();
            }
        }

        public bool DeleteWriterOriginalPublisher(WriterOriginalPublisher WriterOriginalPublisher)
        {
            using (var context = new SampleProjectContext())
            {
                context.WriterOriginalPublishers.Attach(WriterOriginalPublisher);
                context.WriterOriginalPublishers.Remove(WriterOriginalPublisher);
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

        public List<WriterOriginalPublisher> CreateWriterOriginalPublisher(int WriterOriginalPublisherId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.WriterOriginalPublishers.ToList();
            }
        }

        public WriterOriginalPublisher EditWriterOriginalPublisher(WriterOriginalPublisher WriterOriginalPublisher)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(WriterOriginalPublisher).State = EntityState.Modified;
                context.SaveChanges();
                return context.WriterOriginalPublishers.Find(WriterOriginalPublisher.WriterOriginalPublisherId);
            }
        }
    }
}
