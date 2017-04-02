using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface IProductHeaderRepository
    {
        ProductHeader GetProductHeaderById(int ProductHeaderId);
        List<ProductHeader> GetAllProductHeaders();
        bool DeleteProductHeader(ProductHeader ProductHeader);
        List<ProductHeader> CreateProductHeader(int ProductHeaderId);
        ProductHeader EditProductHeader(ProductHeader ProductHeader);
    }
}