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
    public class LicenseProductProductRepository : ILicenseProductProductRepository
    {
        public LicenseProduct GetLicenseProductById(int LicenseProductId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.LicenseProducts.Find(LicenseProductId);
            }
        }

        public List<LicenseProduct> GetAllLicenseProducts()
        {
            using (var context = new SampleProjectContext())
            {
                return context.LicenseProducts.ToList();
            }
        }

        public bool DeleteLicenseProduct(LicenseProduct LicenseProduct)
        {
            using (var context = new SampleProjectContext())
            {
                context.LicenseProducts.Attach(LicenseProduct);
                context.LicenseProducts.Remove(LicenseProduct);
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

        public List<LicenseProduct> CreateLicenseProduct(int LicenseProductId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.LicenseProducts.ToList();
            }
        }

        public LicenseProduct EditLicenseProduct(LicenseProduct LicenseProduct)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(LicenseProduct).State = EntityState.Modified;
                context.SaveChanges();
                return context.LicenseProducts.Find(LicenseProduct.LicenseProductId);
            }
        }
    }
}
