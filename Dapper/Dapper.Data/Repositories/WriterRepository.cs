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
    public class WriterRepository : IWriterRepository
    {
        public Writer GetWriterById(int WriterId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Writers.Find(WriterId);
            }
        }

        public List<Writer> GetAllWriters()
        {
            using (var context = new SampleProjectContext())
            {
                return context.Writers.ToList();
            }
        }

        public bool DeleteWriter(Writer Writer)
        {
            using (var context = new SampleProjectContext())
            {
                context.Writers.Attach(Writer);
                context.Writers.Remove(Writer);
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

        public List<Writer> CreateWriter(int WriterId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Writers.ToList();
            }
        }

        public Writer EditWriter(Writer Writer)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(Writer).State = EntityState.Modified;
                context.SaveChanges();
                return context.Writers.Find(Writer.WriterId);
            }
        }
    }
}
