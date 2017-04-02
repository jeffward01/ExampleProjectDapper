using Dapper.Models.LU_Tables;
using System.Collections.Generic;

namespace Dapper.Models
{
    public class License
    {
        public int LicenseId { get; set; }

        public string LicenseNumber { get; set; }
        public string LicenseName { get; set; }
        public int LicenseStatusId { get; set; }

        public virtual List<LicenseProduct> LicenseProducts { get; set; }
        public virtual LU_LicenseStatus LicesneStatus { get; set; }
    }
}