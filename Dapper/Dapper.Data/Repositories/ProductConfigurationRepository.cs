using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Data.Infrastructure;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public class ProductConfigurationRepository : IProductConfigurationRepository
    {
        public ProductConfiguration GetProductConfigurationById(int ProductConfigurationId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.ProductConfigurations.Find(ProductConfigurationId);
            }
        }

        public List<ProductConfiguration> GetAllProductConfigurations()
        {
            using (var context = new SampleProjectContext())
            {
                return context.ProductConfigurations.ToList();
            }
        }

        public bool DeleteProductConfiguration(ProductConfiguration ProductConfiguration)
        {
            using (var context = new SampleProjectContext())
            {
                context.ProductConfigurations.Attach(ProductConfiguration);
                context.ProductConfigurations.Remove(ProductConfiguration);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        public List<ProductConfiguration> CreateProductConfiguration(int ProductConfigurationId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.ProductConfigurations.ToList();
            }
        }

        public ProductConfiguration EditProductConfiguration(ProductConfiguration ProductConfiguration)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(ProductConfiguration).State = EntityState.Modified;
                context.SaveChanges();
                return context.ProductConfigurations.Find(ProductConfiguration.ProductConfigurationId);
            }
        }
    }
}
