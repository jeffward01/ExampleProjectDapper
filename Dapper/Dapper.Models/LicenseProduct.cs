using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Models
{
    public class LicenseProduct
    {
        public int LicenseProductId { get; set; }
        public int LicenseId { get; set; }
        public string LicenseProductName { get; set; }
        public int ProductHeaderId { get; set; }

        public virtual ProductHeader ProductHeader { get; set; }

        public virtual List<Recording> Recordings { get; set; }
    }
}
