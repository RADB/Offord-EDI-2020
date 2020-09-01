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
    public class CountryService : ICountryService
    {
        private readonly ILogger<CountryService> _logger;
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public CountryService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Country> countryRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<CountryService>();
            _httpContextAccessor = httpContextAccessor;
            _countryRepository = countryRepository;
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

        public async Task DeleteCountryAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteCountryAsync started by:" + _username);

            try
            {
                var country = await _countryRepository.GetByIdAsync(Id);

                Guard.Against.NullCountry(Id, country);

                await _countryRepository.DeleteAsync(country);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteCountryAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateCountryAsync(CountryItemViewModel country)
        {
            await LogUsername();
            Log.Information("UpdateCountryAsync started by:" + _username);

            try
            {
                var _country = await _countryRepository.GetByIdAsync(country.Id);

                Guard.Against.NullCountry(country.Id, _country);

                _country.Code = country.Code;
                _country.English = country.English;
                _country.French = country.French;
                _country.ISO2CountryCode = country.ISO2CountryCode;
                _country.ISO3CountryCode = country.ISO3CountryCode;
                _country.ModifiedDate = DateTime.Now;
                _country.ModifiedBy = _username;

                await _countryRepository.UpdateAsync(_country);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateCountryAsync failed:" + ex.Message);
            }
        }

        public async Task CreateCountryAsync(CountryItemViewModel country)
        {
            await LogUsername();
            Log.Information("CreateCountryAsync started by:" + _username);

            try
            {
                var _country = new Country();

                _country.Code = country.Code;
                _country.English = country.English;
                _country.French = country.French;
                _country.ISO2CountryCode = country.ISO2CountryCode;
                _country.ISO3CountryCode = country.ISO3CountryCode;
                _country.CreatedDate = DateTime.Now;
                _country.CreatedBy = _username;
                _country.ModifiedDate = DateTime.Now;
                _country.ModifiedBy = _username;

                await _countryRepository.AddAsync(_country);
            }
            catch (Exception ex)
            {
                Log.Error("CreateCountryAsync failed:" + ex.Message);
            }
        }

        public async Task<CountryItemViewModel> GetCountryItem(int countryId)
        {
            await LogUsername();
            Log.Information("GetCountryItem started by:" + _username);

            try
            {
                var country = await _countryRepository.GetByIdAsync(countryId);

                Guard.Against.NullCountry(countryId, country);

                var vm = new CountryItemViewModel()
                {
                    Id = country.Id,
                    Code = country.Code,
                    English = country.English,
                    French = country.French,
                    ISO2CountryCode = country.ISO2CountryCode,
                    ISO3CountryCode = country.ISO3CountryCode,
                    CreatedDate = country.CreatedDate.Value,
                    CreatedBy = country.CreatedBy,
                    ModifiedDate = country.ModifiedDate.Value,
                    ModifiedBy = country.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetCountryItem failed:" + ex.Message);

                var vm = new CountryItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int Code, string name)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new CountryFilterSpecification(Code, name);

                var totalItems = await _countryRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int Code, string name, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new CountryFilterSpecification(Code, name, id);

                var totalItems = await _countryRepository.CountAsync(filterSpecification);

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
