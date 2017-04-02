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
    public class ConfigurationTypeRepository : IConfigurationTypeRepository
    {
        public ConfigurationType GetConfigurationTypeById(int ConfigurationTypeId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.ConfigurationTypes.Find(ConfigurationTypeId);
            }
        }

        public List<ConfigurationType> GetAllConfigurationTypes()
        {
            using (var context = new SampleProjectContext())
            {
                return context.ConfigurationTypes.ToList();
            }
        }

        public bool DeleteConfigurationType(ConfigurationType ConfigurationType)
        {
            using (var context = new SampleProjectContext())
            {
                context.ConfigurationTypes.Attach(ConfigurationType);
                context.ConfigurationTypes.Remove(ConfigurationType);
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

        public List<ConfigurationType> CreateConfigurationType(int ConfigurationTypeId)
        {
            using (var context = new SampleProjectContext())
            {
                return context.ConfigurationTypes.ToList();
            }
        }

        public ConfigurationType EditConfigurationType(ConfigurationType ConfigurationType)
        {
            using (var context = new SampleProjectContext())
            {
                context.Entry(ConfigurationType).State = EntityState.Modified;
                context.SaveChanges();
                return context.ConfigurationTypes.Find(ConfigurationType.ConfigurationTypeId);
            }
        }
    }
}
