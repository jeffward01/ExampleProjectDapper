using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Dapper.Repositories;
using Dapper.Data.Repositories;
using Dapper.Models;

namespace Dapper.Business.Managers
{
    public class LicenseManager : ILicenseManager
    {
        private readonly ILicenseRepository _licenseRepository;
        private readonly ILicenseDapperRepository _licenseDapperRepository;
        public LicenseManager(ILicenseRepository licenseRepository, ILicenseDapperRepository licenseDapperRepository)
        {
            _licenseDapperRepository = licenseDapperRepository;
            _licenseRepository = licenseRepository;
        }

        public License CreateLicense(License license)
        {
            return _licenseRepository.CreateLicense(license);
        }

        public License GetLicenseLiteEFByLicenseId(int licenseId)
        {
            return _licenseRepository.GetLicenseById(licenseId);
        }

        public List<License> GetAllLicensesEF()
        {
            return _licenseRepository.GetAllLicenses();
        }

        public License GetLicenseLiteDapperByLicenseId(int licenseId)
        {
            return _licenseDapperRepository.GetLicenseByLicenseId(licenseId);
        }

        public List<License> GetAlllicensesDapper()
        {
            return _licenseDapperRepository.GetAllLicenses();
        }
    }
}
