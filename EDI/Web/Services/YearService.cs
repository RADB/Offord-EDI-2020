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
    public class YearService: IYearService
    {
        private readonly ILogger<YearService> _logger;
        private readonly IAsyncRepository<Year> _yearRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public YearService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Year> yearRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<YearService>();
            _httpContextAccessor = httpContextAccessor;
            _yearRepository = yearRepository;
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

        public async Task DeleteYearAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteYearAsync started by:" + _username);

            try
            {
                var year = await _yearRepository.GetByIdAsync(Id);

                Guard.Against.NullYear(Id, year);

                await _yearRepository.DeleteAsync(year);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteYearAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateYearAsync(YearItemViewModel year)
        {
            await LogUsername();
            Log.Information("UpdateYearAsync started by:" + _username);

            try
            {
                var _year = await _yearRepository.GetByIdAsync(year.Id);

                Guard.Against.NullYear(year.Id, _year);

                _year.Ediyear = year.Ediyear;
                _year.ModifiedDate = DateTime.Now;
                _year.ModifiedBy = _username;

                await _yearRepository.UpdateAsync(_year);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateYearAsync failed:" + ex.Message);
            }
        }

        public async Task CreateYearAsync(YearItemViewModel year)
        {
            await LogUsername();
            Log.Information("CreateYearAsync started by:" + _username);

            try
            {
                var _year = new Year();

                _year.Ediyear = year.Ediyear;
                _year.CreatedDate = DateTime.Now;
                _year.CreatedBy = _username;
                _year.ModifiedDate = DateTime.Now;
                _year.ModifiedBy = _username;

                await _yearRepository.AddAsync(_year);
            }
            catch (Exception ex)
            {
                Log.Error("CreateYearAsync failed:" + ex.Message);
            }
        }

        public async Task<YearItemViewModel> GetYearItem(int yearId)
        {
            await LogUsername();
            Log.Information("GetYearItem started by:" + _username);

            try
            {
                var year = await _yearRepository.GetByIdAsync(yearId);

                Guard.Against.NullYear(yearId, year);

                var vm = new YearItemViewModel()
                {
                    Id = year.Id,
                    Ediyear = year.Ediyear,
                    CreatedDate = year.CreatedDate,
                    CreatedBy = year.CreatedBy,
                    ModifiedDate = year.ModifiedDate,
                    ModifiedBy = year.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetYearItem failed:" + ex.Message);

                var vm = new YearItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int yearnumber)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new YearFilterSpecification(yearnumber);

                var totalItems = await _yearRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int yearnumber, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new YearFilterSpecification(yearnumber, id);

                var totalItems = await _yearRepository.CountAsync(filterSpecification);

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
