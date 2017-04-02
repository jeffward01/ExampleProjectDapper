using System.Collections.Generic;
using Dapper.Models.LU_Tables;

namespace Dapper.Data.Repositories
{
    public interface ILicenseStatusStatusRepository
    {
        LU_LicenseStatus GetLicenseStatusById(int LicenseStatusId);
        List<LU_LicenseStatus> GetAllLicenseStatuss();
        bool DeleteLicenseStatus(LU_LicenseStatus LicenseStatus);
        List<LU_LicenseStatus> CreateLicenseStatus(int LicenseStatusId);
        LU_LicenseStatus EditLicenseStatus(LU_LicenseStatus LicenseStatus);
    }
}