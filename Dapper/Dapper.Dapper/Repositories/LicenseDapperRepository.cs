using System.Collections.Generic;
using Dapper.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Dapper.Dapper.Repositories
{
    public class LicenseDapperRepository : ILicenseDapperRepository
    {
        public License GetLicenseByLicenseId(int licenseId)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SampleProjectContext"].ConnectionString))

            {
                return db.Query<License>("Select * From Licenses WHERE licenseId = @LicenseId",
new { LicenseId = licenseId }).FirstOrDefault();
            }
        }

        public List<License> GetAllLicenses()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SampleProjectContext"].ConnectionString))

            {
                return db.Query<License>("Select * From Licenses").ToList();
            }
        }

    }
}