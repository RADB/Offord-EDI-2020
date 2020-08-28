using EDI.ApplicationCore.Entities;
using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Specifications;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using EDI.Web.Models;
using EDI.Web.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using EDI.Infrastructure.Interfaces;
using Serilog;
using EDI.Web.Lib;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using EDI.Web.Extensions;
using EDI.Infrastructure.Identity;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Syncfusion.Blazor.Data;
using System.Linq;

namespace EDI.Web.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly ILogger<ConfigurationService> _logger;
        private readonly IAsyncRepository<SystemConfigurations> _configurationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public ConfigurationService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<SystemConfigurations> configurationRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<ConfigurationService>();
            _httpContextAccessor = httpContextAccessor;
            _configurationRepository = configurationRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            EDIppSettings = settings.Value;
        }

        private async Task LogUsername()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user != null)
                _username = user.Identity.Name;
            else
                _username = string.Empty;
        }

        public async Task DeleteConfigurationAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteConfigurationAsync started by:" + _username);

            try
            {
                var configuration = await _configurationRepository.GetByIdAsync(Id);

                Guard.Against.NullConfiguration(Id, configuration);

                await _configurationRepository.DeleteAsync(configuration);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteConfigurationAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateConfigurationAsync(ConfigurationItemViewModel configuration)
        {
            await LogUsername();
            Log.Information("UpdateConfigurationAsync started by:" + _username);

            try
            {
                var _configuration = await _configurationRepository.GetByIdAsync(configuration.Id);

                Guard.Against.NullConfiguration(configuration.Id, _configuration);

                _configuration.FieldValue = configuration.FieldValue;
                _configuration.ModifiedDate = DateTime.Now;
                _configuration.ModifiedBy = _username;

                await _configurationRepository.UpdateAsync(_configuration);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateConfigurationAsync failed:" + ex.Message);
            }
        }

        public async Task CreateConfigurationAsync(ConfigurationItemViewModel configuration)
        {
            await LogUsername();
            Log.Information("CreateConfigurationAsync started by:" + _username);

            try
            {
                var _configuration = new SystemConfigurations();

                _configuration.FieldName = configuration.FieldName;
                _configuration.FieldValue = configuration.FieldValue;
                _configuration.CreatedDate = DateTime.Now;
                _configuration.CreatedBy = _username;
                _configuration.ModifiedDate = DateTime.Now;
                _configuration.ModifiedBy = _username;

                await _configurationRepository.AddAsync(_configuration);
            }
            catch (Exception ex)
            {
                Log.Error("CreateConfigurationAsync failed:" + ex.Message);
            }
        }

        public async Task<ConfigurationItemViewModel> GetConfigurationItem(int configurationId)
        {
            await LogUsername();
            Log.Information("GetConfigurationItem started by:" + _username);

            try
            {
                var configuration = await _configurationRepository.GetByIdAsync(configurationId);

                Guard.Against.NullConfiguration(configurationId, configuration);

                var vm = new ConfigurationItemViewModel()
                {
                    Id = configuration.Id,
                    FieldName = configuration.FieldName,
                    FieldValue = configuration.FieldValue,
                    CreatedDate = configuration.CreatedDate,
                    CreatedBy = configuration.CreatedBy,
                    ModifiedDate = configuration.ModifiedDate,
                    ModifiedBy = configuration.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetConfigurationItem failed:" + ex.Message);

                var vm = new ConfigurationItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string name)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new ConfigurationFilterSpecification(name);

                var totalItems = await _configurationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string name, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new ConfigurationFilterSpecification(name, id);

                var totalItems = await _configurationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }
    }
}
