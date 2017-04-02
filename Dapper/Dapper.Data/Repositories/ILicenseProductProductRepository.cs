using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface ILicenseProductProductRepository
    {
        LicenseProduct GetLicenseProductById(int LicenseProductId);
        List<LicenseProduct> GetAllLicenseProducts();
        bool DeleteLicenseProduct(LicenseProduct LicenseProduct);
        List<LicenseProduct> CreateLicenseProduct(int LicenseProductId);
        LicenseProduct EditLicenseProduct(LicenseProduct LicenseProduct);
    }
}