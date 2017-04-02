using System.Collections.Generic;

namespace Dapper.Models
{
    public class Writer
    {
        public int WriterId { get; set; }
        public int WriterName { get; set; }
        public int RecordingId { get; set; }
        public string CaeNumber { get; set; }
        public bool Controlled { get; set; }
        public int IpCode { get; set; }
        public decimal Contribution { get; set; }
        public int OriginalPublisherCount { get; set; }
        public virtual List<WriterOriginalPublisher> OriginalPublishers { get; set; }
    }
}