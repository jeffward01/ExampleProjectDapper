using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Models
{
    public class TrackComposer
    {
        public int TrackComposerId { get; set; }
        public int TrackId { get; set; }

        public string ComposerName { get; set; }
    }
}
