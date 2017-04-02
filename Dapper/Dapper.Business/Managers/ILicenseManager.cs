using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Business.Managers
{
    public interface ILicenseManager
    {
        License CreateLicense(License license);
        License GetLicenseLiteEFByLicenseId(int licenseId);
        List<License> GetAllLicensesEF();
        License GetLicenseLiteDapperByLicenseId(int licenseId);
        List<License> GetAlllicensesDapper();
    }
}