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
    public class SiteService: ISiteService
    {
        private readonly ILogger<SiteService> _logger;
        private readonly IAsyncRepository<Site> _siteRepository;
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

        public SiteService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Site> siteRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<SiteService>();
            _httpContextAccessor = httpContextAccessor;
            _siteRepository = siteRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteSiteAsync(int Id)
        {
            
            _sharedService.WriteLogs("DeleteSiteAsync started by:" + _userSettings.UserName, true);

            try
            {
                var site = await _siteRepository.GetByIdAsync(Id);

                Guard.Against.NullSite(Id, site);

                await _siteRepository.DeleteAsync(site);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteSiteAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateSiteAsync(SiteItemViewModel site)
        {
            
            _sharedService.WriteLogs("UpdateSiteAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _site = await _siteRepository.GetByIdAsync(site.Id);

                Guard.Against.NullSite(site.Id, _site);

                _site.SiteNumber = site.SiteNumber;
                _site.SiteName = site.SiteName;
                _site.IsTestSite = site.IsTestSite;
                _site.Description = site.Description;
                _site.CoordinatorId = site.CoordinatorId;
                _site.YearId = site.YearId;
                _site.ModifiedDate = DateTime.Now;
                _site.ModifiedBy = _userSettings.UserName;

                await _siteRepository.UpdateAsync(_site);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateSiteAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateSiteAsync(SiteItemViewModel site)
        {
            
            _sharedService.WriteLogs("CreateSiteAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _site = new Site();

                _site.SiteNumber = site.SiteNumber;
                _site.SiteName = site.SiteName;
                _site.Description = site.Description;
                _site.CoordinatorId = site.CoordinatorId;
                _site.IsTestSite = site.IsTestSite;
                _site.YearId = site.YearId;
                _site.CreatedDate = DateTime.Now;
                _site.CreatedBy = _userSettings.UserName;
                _site.ModifiedDate = DateTime.Now;
                _site.ModifiedBy = _userSettings.UserName;

                await _siteRepository.AddAsync(_site);
                return _site.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateSiteAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<SiteItemViewModel> GetSiteItem(int siteId)
        {
            
            _sharedService.WriteLogs("GetSiteItem started by:" + _userSettings.UserName, true);

            try
            {
                var site = await _siteRepository.GetByIdAsync(siteId);

                Guard.Against.NullSite(siteId, site);

                var vm = new SiteItemViewModel()
                {
                    Id = site.Id,
                    SiteNumber = site.SiteNumber,
                    SiteName = site.SiteName,
                    Description = site.Description,
                    IsTestSite = site.IsTestSite,
                    CoordinatorId = site.CoordinatorId,
                    YearId = site.YearId,
                    CreatedDate = site.CreatedDate,
                    CreatedBy = site.CreatedBy,
                    ModifiedDate = site.ModifiedDate,
                    ModifiedBy = site.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetSiteItem failed:" + ex.Message, false);

                var vm = new SiteItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string sitenumber, int yearid)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new SiteFilterSpecification(sitenumber, yearid);

                var totalItems = await _siteRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string sitenumber, int id, int yearid)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new SiteFilterSpecification(sitenumber, yearid, id);

                var totalItems = await _siteRepository.CountAsync(filterSpecification);

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
