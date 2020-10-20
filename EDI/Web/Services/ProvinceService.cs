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
    public class ProvinceService : IProvinceService
    {
        private readonly ILogger<ProvinceService> _logger;
        private readonly IAsyncRepository<Province> _provinceRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public ProvinceService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Province> provinceRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<ProvinceService>();
            _httpContextAccessor = httpContextAccessor;
            _provinceRepository = provinceRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteProvinceAsync(int Id)
        {
            
            Log.Information("DeleteProvinceAsync started by:" + _userSettings.UserName);

            try
            {
                var province = await _provinceRepository.GetByIdAsync(Id);

                Guard.Against.NullProvince(Id, province);

                await _provinceRepository.DeleteAsync(province);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteProvinceAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateProvinceAsync(ProvinceItemViewModel province)
        {
            
            Log.Information("UpdateProvinceAsync started by:" + _userSettings.UserName);

            try
            {
                var _province = await _provinceRepository.GetByIdAsync(province.Id);

                Guard.Against.NullProvince(province.Id, _province);

                _province.Code = province.Code;
                _province.EDICode = province.EDICode;
                _province.English = province.English;
                _province.French = province.French;
                _province.CountryID = province.CountryID;
                _province.ModifiedDate = DateTime.Now;
                _province.ModifiedBy = _userSettings.UserName;

                await _provinceRepository.UpdateAsync(_province);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateProvinceAsync failed:" + ex.Message);
            }
        }

        public async Task CreateProvinceAsync(ProvinceItemViewModel province)
        {
            
            Log.Information("CreateProvinceAsync started by:" + _userSettings.UserName);

            try
            {
                var _province = new Province();

                _province.Code = province.Code;
                _province.EDICode = province.EDICode;
                _province.English = province.English;
                _province.French = province.French;
                _province.CountryID = province.CountryID;
                _province.CreatedDate = DateTime.Now;
                _province.CreatedBy = _userSettings.UserName;
                _province.ModifiedDate = DateTime.Now;
                _province.ModifiedBy = _userSettings.UserName;

                await _provinceRepository.AddAsync(_province);
            }
            catch (Exception ex)
            {
                Log.Error("CreateProvinceAsync failed:" + ex.Message);
            }
        }

        public async Task<ProvinceItemViewModel> GetProvinceItem(int provinceId)
        {
            
            Log.Information("GetProvinceItem started by:" + _userSettings.UserName);

            try
            {
                var province = await _provinceRepository.GetByIdAsync(provinceId);

                Guard.Against.NullProvince(provinceId, province);

                var vm = new ProvinceItemViewModel()
                {
                    Id = province.Id,
                    Code = province.Code,
                    EDICode = province.EDICode,
                    English = province.English,
                    French = province.French,
                    CountryID = province.CountryID,
                    CreatedDate = province.CreatedDate,
                    CreatedBy = province.CreatedBy,
                    ModifiedDate = province.ModifiedDate,
                    ModifiedBy = province.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetProvinceItem failed:" + ex.Message);

                var vm = new ProvinceItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int countryid, string name)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new ProvinceFilterSpecification(countryid, name);

                var totalItems = await _provinceRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int countryid, string name, int id)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new ProvinceFilterSpecification(countryid, name, id);

                var totalItems = await _provinceRepository.CountAsync(filterSpecification);

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
