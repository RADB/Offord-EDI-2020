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

        private string _username { get; set; }

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
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<SiteService>();
            _httpContextAccessor = httpContextAccessor;
            _siteRepository = siteRepository;
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

        public async Task DeleteSiteAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteSiteAsync started by:" + _username);

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
            await LogUsername();
            Log.Information("UpdateSiteAsync started by:" + _username);

            try
            {
                var _site = await _siteRepository.GetByIdAsync(site.Id);

                Guard.Against.NullSite(site.Id, _site);

                _site.SiteNumber = site.SiteNumber;
                _site.SiteName = site.SiteName;
                _site.Description = site.Description;
                //_site.CoordinatorId = site.CoordinatorId;
                _site.ModifiedDate = DateTime.Now;
                _site.ModifiedBy = _username;

                await _siteRepository.UpdateAsync(_site);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateSiteAsync failed:" + ex.Message);
            }
        }

        public async Task CreateSiteAsync(SiteItemViewModel site)
        {
            await LogUsername();
            Log.Information("CreateSiteAsync started by:" + _username);

            try
            {
                var _site = new Site();

                _site.SiteNumber = site.SiteNumber;
                _site.SiteName = site.SiteName;
                _site.Description = site.Description;
                //_site.CoordinatorId = site.CoordinatorId;
                _site.CreatedDate = DateTime.Now;
                _site.CreatedBy = _username;
                _site.ModifiedDate = DateTime.Now;
                _site.ModifiedBy = _username;

                await _siteRepository.AddAsync(_site);
            }
            catch (Exception ex)
            {
                Log.Error("CreateSiteAsync failed:" + ex.Message);
            }
        }

        public async Task<SiteItemViewModel> GetSiteItem(int siteId)
        {
            await LogUsername();
            Log.Information("GetSiteItem started by:" + _username);

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
                    //CoordinatorId = site.CoordinatorId,
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
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

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
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

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

        public async Task<IEnumerable<SelectListItem>> GetSites()
        {
            await LogUsername();
            Log.Information("GetSites started by:" + _username);

            try
            {
                var sites = _siteRepository.ListAllSites().OrderBy(t=> t.SiteNumber);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var site in sites)
                {
                    items.Add(new SelectListItem() { Value = site.Id.ToString(), Text = site.SiteNumber});
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetSites failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }
    }
}
