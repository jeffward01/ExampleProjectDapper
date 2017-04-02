using Dapper.Data.Infrastructure;
using Dapper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Dapper.Data.Repositories
{
    public class LicenseRepository : ILicenseRepository
    {
        public License GetLicenseById(int LicenseId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.Licenses.Find(LicenseId);
            }
        }

        public List<License> GetAllLicenses()
        {
            using (var context = new SampleProjectContext())
            {
                return context.Licenses.ToList();
            }
        }

        public bool DeleteLicense(License License)
        {
            using (var context = new SampleProjectContext())
            {
                context.Licenses.Attach(License);
                context.Licenses.Remove(License);
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

        public License CreateLicense(License license)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(license).State = EntityState.Added;
                context.SaveChanges();
                return license;
            }
        }

        public License EditLicense(License License)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(License).State = EntityState.Modified;
                context.SaveChanges();
                return context.Licenses.Find(License.LicenseId);
            }
        }
    }
}