using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IConfigurationService
    {
        Task DeleteConfigurationAsync(int Id);

        Task UpdateConfigurationAsync(ConfigurationItemViewModel configuration);

        Task CreateConfigurationAsync(ConfigurationItemViewModel configuration);

        Task<ConfigurationItemViewModel> GetConfigurationItem(int configurationId);

        Task<int> GetDuplicateCount(string name);
        Task<int> GetDuplicateCount(string name, int id);
    }
}
