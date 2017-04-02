using System.Collections.Generic;
using Dapper.Models;

namespace Dapper.Data.Repositories
{
    public interface ILicenseRepository
    {
        License GetLicenseById(int LicenseId);
        List<License> GetAllLicenses();
        bool DeleteLicense(License License);
        License CreateLicense(License LicenseId);
        License EditLicense(License License);
    }
}