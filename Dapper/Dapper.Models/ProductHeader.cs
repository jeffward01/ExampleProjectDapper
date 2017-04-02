using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Models
{
    public class ProductHeader
    {
        public int ProductHeaderId { get; set; }
        public int LicenseProductId { get; set; }
        public List<ProductConfiguration> ProductConfigurations { get; set; }
        public string ProductName { get; set; }
    }
}
