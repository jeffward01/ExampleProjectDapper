using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface IWriterOriginalPublisherRepository
    {
        WriterOriginalPublisher GetWriterOriginalPublisherById(int WriterOriginalPublisherId);
        List<WriterOriginalPublisher> GetAllWriterOriginalPublishers();
        bool DeleteWriterOriginalPublisher(WriterOriginalPublisher WriterOriginalPublisher);
        List<WriterOriginalPublisher> CreateWriterOriginalPublisher(int WriterOriginalPublisherId);
        WriterOriginalPublisher EditWriterOriginalPublisher(WriterOriginalPublisher WriterOriginalPublisher);
    }
}