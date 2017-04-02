using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface IProductConfigurationRepository
    {
        ProductConfiguration GetProductConfigurationById(int ProductConfigurationId);
        List<ProductConfiguration> GetAllProductConfigurations();
        bool DeleteProductConfiguration(ProductConfiguration ProductConfiguration);
        List<ProductConfiguration> CreateProductConfiguration(int ProductConfigurationId);
        ProductConfiguration EditProductConfiguration(ProductConfiguration ProductConfiguration);
    }
}