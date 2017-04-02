using System.Collections.Generic;

namespace Dapper.Models
{
    public class Recording
    {
        public int RecordingId { get; set; }
        public int LicenseProductId { get; set; }
        public int WriterCount { get; set; }
        public int CdIndex { get; set; }
        public int CdNumber { get; set; }
        public int UmpgPercentage { get; set; }

        public int TrackId { get; set; }
        public virtual Track Track { get; set; }
        public virtual List<Writer> Writers { get; set; }
    }
}