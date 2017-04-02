using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Data.Infrastructure;
using Dapper.Models.LU_Tables;

namespace Dapper.Data.Repositories
{
    public class LicenseStatusStatusRepository : ILicenseStatusStatusRepository
    {
        public LU_LicenseStatus GetLicenseStatusById(int LicenseStatusId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.LicenseStatuses.Find(LicenseStatusId);
            }
        }

        public List<LU_LicenseStatus> GetAllLicenseStatuss()
        {
            using (var context = new SampleProjectContext())
            {
                return context.LicenseStatuses.ToList();
            }
        }

        public bool DeleteLicenseStatus(LU_LicenseStatus LicenseStatus)
        {
            using (var context = new SampleProjectContext())
            {
                context.LicenseStatuses.Attach(LicenseStatus);
                context.LicenseStatuses.Remove(LicenseStatus);
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

        public List<LU_LicenseStatus> CreateLicenseStatus(int LicenseStatusId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.LicenseStatuses.ToList();
            }
        }

        public LU_LicenseStatus EditLicenseStatus(LU_LicenseStatus LicenseStatus)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(LicenseStatus).State = EntityState.Modified;
                context.SaveChanges();
                return context.LicenseStatuses.Find(LicenseStatus.LicenseStatusId);
            }
        }
    }
}
