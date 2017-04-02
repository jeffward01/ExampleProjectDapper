using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Models.LU_Tables;

namespace Dapper.Models
{
   public class ProductConfiguration
    {
        public int ProductConfigurationId { get; set; }
        public int ProductHeaderId { get; set; }
        public string UpcCode { get; set; }
        public int ConfigurationId { get; set; }
        public virtual ConfigurationType ConfigurationType { get; set; }
    }
}
