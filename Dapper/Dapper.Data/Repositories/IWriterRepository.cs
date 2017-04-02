using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface IWriterRepository
    {
        Writer GetWriterById(int WriterId);
        List<Writer> GetAllWriters();
        bool DeleteWriter(Writer Writer);
        List<Writer> CreateWriter(int WriterId);
        Writer EditWriter(Writer Writer);
    }
}