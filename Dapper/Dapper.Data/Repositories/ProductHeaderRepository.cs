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
    public class ProductHeaderRepository : IProductHeaderRepository
    {
        public ProductHeader GetProductHeaderById(int ProductHeaderId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.ProductHeaders.Find(ProductHeaderId);
            }
        }

        public List<ProductHeader> GetAllProductHeaders()
        {
            using (var context = new SampleProjectContext())
            {
                return context.ProductHeaders.ToList();
            }
        }

        public bool DeleteProductHeader(ProductHeader ProductHeader)
        {
            using (var context = new SampleProjectContext())
            {
                context.ProductHeaders.Attach(ProductHeader);
                context.ProductHeaders.Remove(ProductHeader);
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

        public List<ProductHeader> CreateProductHeader(int ProductHeaderId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.ProductHeaders.ToList();
            }
        }

        public ProductHeader EditProductHeader(ProductHeader ProductHeader)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(ProductHeader).State = EntityState.Modified;
                context.SaveChanges();
                return context.ProductHeaders.Find(ProductHeader.ProductHeaderId);
            }
        }

    }
}
