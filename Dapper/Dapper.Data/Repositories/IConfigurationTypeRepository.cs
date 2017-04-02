using System.Collections.Generic;
using Dapper.Models.LU_Tables;

namespace Dapper.Data.Repositories
{
    public interface IConfigurationTypeRepository
    {
        ConfigurationType GetConfigurationTypeById(int ConfigurationTypeId);
        List<ConfigurationType> GetAllConfigurationTypes();
        bool DeleteConfigurationType(ConfigurationType ConfigurationType);
        List<ConfigurationType> CreateConfigurationType(int ConfigurationTypeId);
        ConfigurationType EditConfigurationType(ConfigurationType ConfigurationType);
    }
}