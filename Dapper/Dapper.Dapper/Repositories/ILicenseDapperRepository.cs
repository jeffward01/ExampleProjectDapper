using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Dapper.Repositories
{
    public interface ILicenseDapperRepository
    {
        License GetLicenseByLicenseId(int licenseId);
        List<License> GetAllLicenses();
    }
}