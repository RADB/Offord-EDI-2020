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
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;
        private readonly ISharedService _sharedService;

        public YearService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Year> yearRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<YearService>();
            _httpContextAccessor = httpContextAccessor;
            _yearRepository = yearRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteYearAsync(int Id)
        {
            
            _sharedService.WriteLogs("DeleteYearAsync started by:" + _userSettings.UserName, true);

            try
            {
                var year = await _yearRepository.GetByIdAsync(Id);

                Guard.Against.NullYear(Id, year);

                await _yearRepository.DeleteAsync(year);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteYearAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateYearAsync(YearItemViewModel year)
        {
            
            _sharedService.WriteLogs("UpdateYearAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _year = await _yearRepository.GetByIdAsync(year.Id);

                Guard.Against.NullYear(year.Id, _year);

                _year.Ediyear = year.Ediyear;
                _year.Alberta = year.Alberta;
                _year.BritishColumbia = year.BritishColumbia;
                _year.Manitoba = year.Manitoba;
                _year.NewBrunswick = year.NewBrunswick;
                _year.NewfoundlandandLabrador = year.NewfoundlandandLabrador;
                _year.NovaScotia = year.NovaScotia;
                _year.Nunavut = year.Nunavut;
                _year.Ontario = year.Ontario;
                _year.PrinceEdwardIsland = year.PrinceEdwardIsland;
                _year.Quebec = year.Quebec;
                _year.Saskatchewan = year.Saskatchewan;
                _year.YukonTerritory = year.YukonTerritory;
                _year.NorthwestTerritories = year.NorthwestTerritories;
                _year.NewYork = year.NewYork;
                _year.FirstNations = year.FirstNations;
                _year.MCFN = year.MCFN;
                _year.ModifiedDate = DateTime.Now;
                _year.ModifiedBy = _userSettings.UserName;

                await _yearRepository.UpdateAsync(_year);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateYearAsync failed:" + ex.Message, false);
            }
        }

        public async Task CreateYearAsync(YearItemViewModel year)
        {
            
            _sharedService.WriteLogs("CreateYearAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _year = new Year();

                _year.Ediyear = year.Ediyear;
                _year.Alberta = year.Alberta;
                _year.BritishColumbia = year.BritishColumbia;
                _year.Manitoba = year.Manitoba;
                _year.NewBrunswick = year.NewBrunswick;
                _year.NewfoundlandandLabrador = year.NewfoundlandandLabrador;
                _year.NovaScotia = year.NovaScotia;
                _year.Nunavut = year.Nunavut;
                _year.Ontario = year.Ontario;
                _year.PrinceEdwardIsland = year.PrinceEdwardIsland;
                _year.Quebec = year.Quebec;
                _year.Saskatchewan = year.Saskatchewan;
                _year.YukonTerritory = year.YukonTerritory;
                _year.NorthwestTerritories = year.NorthwestTerritories;
                _year.NewYork = year.NewYork;
                _year.FirstNations = year.FirstNations;
                _year.MCFN= year.MCFN;
                _year.CreatedDate = DateTime.Now;
                _year.CreatedBy = _userSettings.UserName;
                _year.ModifiedDate = DateTime.Now;
                _year.ModifiedBy = _userSettings.UserName;

                await _yearRepository.AddAsync(_year);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateYearAsync failed:" + ex.Message, false);
            }
        }

        public async Task<YearItemViewModel> GetYearItem(int yearId)
        {
            
            _sharedService.WriteLogs("GetYearItem started by:" + _userSettings.UserName, true);

            try
            {
                var year = await _yearRepository.GetByIdAsync(yearId);

                Guard.Against.NullYear(yearId, year);

                var vm = new YearItemViewModel()
                {
                    Id = year.Id,
                    Ediyear = year.Ediyear,
                    Alberta = year.Alberta.HasValue ? year.Alberta.Value : false,
                    BritishColumbia = year.BritishColumbia.HasValue ? year.BritishColumbia.Value : false,
                    Manitoba = year.Manitoba.HasValue ? year.Manitoba.Value : false,
                    NewBrunswick = year.NewBrunswick.HasValue ? year.NewBrunswick.Value : false,
                    NewfoundlandandLabrador = year.NewfoundlandandLabrador.HasValue ? year.NewfoundlandandLabrador.Value : false,
                    NovaScotia = year.NovaScotia.HasValue ? year.NovaScotia.Value : false,
                    Nunavut = year.Nunavut.HasValue ? year.Nunavut.Value : false,
                    Ontario = year.Ontario.HasValue ? year.Ontario.Value : false,
                    PrinceEdwardIsland = year.PrinceEdwardIsland.HasValue ? year.PrinceEdwardIsland.Value : false,
                    Quebec = year.Quebec.HasValue ? year.Quebec.Value : false,
                    Saskatchewan = year.Saskatchewan.HasValue ? year.Saskatchewan.Value : false,
                    YukonTerritory = year.YukonTerritory.HasValue ? year.YukonTerritory.Value : false,
                    NorthwestTerritories = year.NorthwestTerritories.HasValue ? year.NorthwestTerritories.Value : false,
                    NewYork = year.NewYork.HasValue ? year.NewYork.Value : false,
                    FirstNations = year.FirstNations.HasValue ? year.FirstNations.Value : false,
                    MCFN = year.MCFN.HasValue ? year.MCFN.Value : false,
                    CreatedDate = year.CreatedDate,
                    CreatedBy = year.CreatedBy,
                    ModifiedDate = year.ModifiedDate,
                    ModifiedBy = year.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetYearItem failed:" + ex.Message, false);

                var vm = new YearItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int yearnumber)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new YearFilterSpecification(yearnumber);

                var totalItems = await _yearRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int yearnumber, int id)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new YearFilterSpecification(yearnumber, id);

                var totalItems = await _yearRepository.CountAsync(filterSpecification);

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
