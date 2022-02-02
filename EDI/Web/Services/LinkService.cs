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
    public class LinkService : ILinkService
    {
        private readonly ILogger<LinkService> _logger;
        private readonly IAsyncRepository<Link> _linkRepository;
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

        public LinkService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Link> linkRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<LinkService>();
            _httpContextAccessor = httpContextAccessor;
            _linkRepository = linkRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteLinkAsync(int Id)
        {

            _sharedService.WriteLogs("DeleteLinkAsync started by:" + _userSettings.UserName, true);

            try
            {
                var link = await _linkRepository.GetByIdAsync(Id);

                Guard.Against.NullLink(Id, link);

                await _linkRepository.DeleteAsync(link);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteLinkAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateLinkAsync(LinkItemViewModel link)
        {

            _sharedService.WriteLogs("UpdateLinkAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _link = await _linkRepository.GetByIdAsync(link.Id);

                Guard.Against.NullLink(link.Id, _link);

                _link.Name = link.Name.Trim();
                _link.Url = link.Url.Trim();
                _link.Description = string.IsNullOrEmpty(link.Description) ? null : link.Description.Trim();
                _link.IsAdminLink = link.IsAdminLink;
                _link.IsCoordinatorLink = link.IsCoordinatorLink;
                _link.IsTeacherLink = link.IsTeacherLink;
                _link.Sequence = link.Sequence;
                _link.YearId = link.YearId;
                _link.Alberta = link.Alberta;
                _link.BritishColumbia = link.BritishColumbia;
                _link.Manitoba = link.Manitoba;
                _link.NewBrunswick = link.NewBrunswick;
                _link.NewfoundlandandLabrador = link.NewfoundlandandLabrador;
                _link.NovaScotia = link.NovaScotia;
                _link.Nunavut = link.Nunavut;
                _link.Ontario = link.Ontario;
                _link.PrinceEdwardIsland = link.PrinceEdwardIsland;
                _link.Quebec = link.Quebec;
                _link.Saskatchewan = link.Saskatchewan;
                _link.YukonTerritory = link.YukonTerritory;
                _link.NorthwestTerritories = link.NorthwestTerritories;
                _link.ModifiedDate = DateTime.Now;
                _link.ModifiedBy = _userSettings.UserName;

                await _linkRepository.UpdateAsync(_link);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateLinkAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateLinkAsync(LinkItemViewModel link)
        {

            _sharedService.WriteLogs("CreateLinkAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _link = new Link();

                _link.Name = link.Name.Trim();
                _link.Url = link.Url.Trim();
                _link.Description = string.IsNullOrEmpty(link.Description) ? null : link.Description.Trim();
                _link.IsAdminLink = link.IsAdminLink;
                _link.IsCoordinatorLink = link.IsCoordinatorLink;
                _link.IsTeacherLink = link.IsTeacherLink;
                _link.Sequence = link.Sequence;
                _link.YearId = link.YearId;
                _link.Alberta = link.Alberta;
                _link.BritishColumbia = link.BritishColumbia;
                _link.Manitoba = link.Manitoba;
                _link.NewBrunswick = link.NewBrunswick;
                _link.NewfoundlandandLabrador = link.NewfoundlandandLabrador;
                _link.NovaScotia = link.NovaScotia;
                _link.Nunavut = link.Nunavut;
                _link.Ontario = link.Ontario;
                _link.PrinceEdwardIsland = link.PrinceEdwardIsland;
                _link.Quebec = link.Quebec;
                _link.Saskatchewan = link.Saskatchewan;
                _link.YukonTerritory = link.YukonTerritory;
                _link.NorthwestTerritories = link.NorthwestTerritories;
                _link.CreatedDate = DateTime.Now;
                _link.CreatedBy = _userSettings.UserName;
                _link.ModifiedDate = DateTime.Now;
                _link.ModifiedBy = _userSettings.UserName;

                await _linkRepository.AddAsync(_link);
                return _link.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateLinkAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<LinkItemViewModel> GetLinkItem(int linkId)
        {

            _sharedService.WriteLogs("GetLinkItem started by:" + _userSettings.UserName, true);

            try
            {
                var link = await _linkRepository.GetByIdAsync(linkId);

                Guard.Against.NullLink(linkId, link);

                var vm = new LinkItemViewModel()
                {
                    Id = link.Id,
                    Name = link.Name,
                    Url = link.Url,
                    Description = link.Description,
                    IsAdminLink = link.IsAdminLink,
                    IsCoordinatorLink = link.IsCoordinatorLink,
                    IsTeacherLink = link.IsTeacherLink,
                    Sequence = link.Sequence,
                    YearId = link.YearId,
                    Alberta = link.Alberta.HasValue ? link.Alberta.Value : false,
                    BritishColumbia = link.BritishColumbia.HasValue ? link.BritishColumbia.Value : false,
                    Manitoba = link.Manitoba.HasValue ? link.Manitoba.Value : false,
                    NewBrunswick = link.NewBrunswick.HasValue ? link.NewBrunswick.Value : false,
                    NewfoundlandandLabrador = link.NewfoundlandandLabrador.HasValue ? link.NewfoundlandandLabrador.Value : false,
                    NovaScotia = link.NovaScotia.HasValue ? link.NovaScotia.Value : false,
                    Nunavut = link.Nunavut.HasValue ? link.Nunavut.Value : false,
                    Ontario = link.Ontario.HasValue ? link.Ontario.Value : false,
                    PrinceEdwardIsland = link.PrinceEdwardIsland.HasValue ? link.PrinceEdwardIsland.Value : false,
                    Quebec = link.Quebec.HasValue ? link.Quebec.Value : false,
                    Saskatchewan = link.Saskatchewan.HasValue ? link.Saskatchewan.Value : false,
                    YukonTerritory = link.YukonTerritory.HasValue ? link.YukonTerritory.Value : false,
                    NorthwestTerritories = link.NorthwestTerritories.HasValue ? link.NorthwestTerritories.Value : false,
                    CreatedDate = link.CreatedDate,
                    CreatedBy = link.CreatedBy,
                    ModifiedDate = link.ModifiedDate,
                    ModifiedBy = link.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetLinkItem failed:" + ex.Message, false);

                var vm = new LinkItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string url, int yearid)
        {

            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new LinkFilterSpecification(url, yearid);

                var totalItems = await _linkRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string url, int id, int yearid)
        {

            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new LinkFilterSpecification(url, yearid, id);

                var totalItems = await _linkRepository.CountAsync(filterSpecification);

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
