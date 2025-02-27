﻿using EDI.ApplicationCore.Entities;
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
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;
        private readonly ISharedService _sharedService;

        public CountryService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Country> countryRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<CountryService>();
            _httpContextAccessor = httpContextAccessor;
            _countryRepository = countryRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteCountryAsync(int Id)
        {
            
            _sharedService.WriteLogs("DeleteCountryAsync started by:" + _userSettings.UserName, true);

            try
            {
                var country = await _countryRepository.GetByIdAsync(Id);

                Guard.Against.NullCountry(Id, country);

                await _countryRepository.DeleteAsync(country);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteCountryAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateCountryAsync(CountryItemViewModel country)
        {
            
            _sharedService.WriteLogs("UpdateCountryAsync started by:" + _userSettings.UserName, true);

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
                _country.ModifiedBy = _userSettings.UserName;

                await _countryRepository.UpdateAsync(_country);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateCountryAsync failed:" + ex.Message, false);
            }
        }

        public async Task CreateCountryAsync(CountryItemViewModel country)
        {
            
            _sharedService.WriteLogs("CreateCountryAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _country = new Country();

                _country.Code = country.Code;
                _country.English = country.English;
                _country.French = country.French;
                _country.ISO2CountryCode = country.ISO2CountryCode;
                _country.ISO3CountryCode = country.ISO3CountryCode;
                _country.CreatedDate = DateTime.Now;
                _country.CreatedBy = _userSettings.UserName;
                _country.ModifiedDate = DateTime.Now;
                _country.ModifiedBy = _userSettings.UserName;

                await _countryRepository.AddAsync(_country);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateCountryAsync failed:" + ex.Message, false);
            }
        }

        public async Task<CountryItemViewModel> GetCountryItem(int countryId)
        {
            
            _sharedService.WriteLogs("GetCountryItem started by:" + _userSettings.UserName, true);

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
                    CreatedDate = country.CreatedDate,
                    CreatedBy = country.CreatedBy,
                    ModifiedDate = country.ModifiedDate,
                    ModifiedBy = country.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetCountryItem failed:" + ex.Message, false);

                var vm = new CountryItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int Code, string name)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new CountryFilterSpecification(Code, name);

                var totalItems = await _countryRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int Code, string name, int id)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new CountryFilterSpecification(Code, name, id);

                var totalItems = await _countryRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }
    }
}
