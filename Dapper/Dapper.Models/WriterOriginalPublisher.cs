using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Models
{
    public class WriterOriginalPublisher
    {
        public int WriterOriginalPublisherId { get; set; }
        public int WriterId { get; set; }
        public string OriginalPublisherName { get; set; }

        public string Capacity { get; set; }
        public bool Controlled { get; set; }
    }
}
