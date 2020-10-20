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

        public SiteService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Site> siteRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
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
        }

        public async Task DeleteSiteAsync(int Id)
        {
            
            Log.Information("DeleteSiteAsync started by:" + _userSettings.UserName);

            try
            {
                var site = await _siteRepository.GetByIdAsync(Id);

                Guard.Against.NullSite(Id, site);

                await _siteRepository.DeleteAsync(site);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteSiteAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateSiteAsync(SiteItemViewModel site)
        {
            
            Log.Information("UpdateSiteAsync started by:" + _userSettings.UserName);

            try
            {
                var _site = await _siteRepository.GetByIdAsync(site.Id);

                Guard.Against.NullSite(site.Id, _site);

                _site.SiteNumber = site.SiteNumber;
                _site.SiteName = site.SiteName;
                _site.Description = site.Description;
                _site.CoordinatorId = site.CoordinatorId;
                _site.YearId = site.YearId;
                _site.ModifiedDate = DateTime.Now;
                _site.ModifiedBy = _userSettings.UserName;

                await _siteRepository.UpdateAsync(_site);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateSiteAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateSiteAsync(SiteItemViewModel site)
        {
            
            Log.Information("CreateSiteAsync started by:" + _userSettings.UserName);

            try
            {
                var _site = new Site();

                _site.SiteNumber = site.SiteNumber;
                _site.SiteName = site.SiteName;
                _site.Description = site.Description;
                _site.CoordinatorId = site.CoordinatorId;
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
                Log.Error("CreateSiteAsync failed:" + ex.Message);
                return 0;
            }
        }

        public async Task<SiteItemViewModel> GetSiteItem(int siteId)
        {
            
            Log.Information("GetSiteItem started by:" + _userSettings.UserName);

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
                Log.Error("GetSiteItem failed:" + ex.Message);

                var vm = new SiteItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string sitenumber)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new SiteFilterSpecification(sitenumber);

                var totalItems = await _siteRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string sitenumber, int id)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new SiteFilterSpecification(sitenumber, id);

                var totalItems = await _siteRepository.CountAsync(filterSpecification);

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
