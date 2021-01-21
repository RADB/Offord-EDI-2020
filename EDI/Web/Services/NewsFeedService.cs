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
    public class NewsFeedService : INewsFeedService
    {
        private readonly ILogger<NewsFeedService> _logger;
        private readonly IAsyncRepository<NewsFeed> _newsFeedRepository;
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

        public NewsFeedService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<NewsFeed> newsFeedRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<NewsFeedService>();
            _httpContextAccessor = httpContextAccessor;
            _newsFeedRepository = newsFeedRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteNewsFeedAsync(int Id)
        {

            _sharedService.WriteLogs("DeleteNewsFeedAsync started by:" + _userSettings.UserName, true);

            try
            {
                var newsFeed = await _newsFeedRepository.GetByIdAsync(Id);

                Guard.Against.NullNewsFeed(Id, newsFeed);

                await _newsFeedRepository.DeleteAsync(newsFeed);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteNewsFeedAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateNewsFeedAsync(NewsFeedItemViewModel newsFeed)
        {

            _sharedService.WriteLogs("UpdateNewsFeedAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _newsFeed = await _newsFeedRepository.GetByIdAsync(newsFeed.Id);

                Guard.Against.NullNewsFeed(newsFeed.Id, _newsFeed);

                _newsFeed.Title = newsFeed.Title;
                _newsFeed.Text = newsFeed.Text;
                _newsFeed.Summary = newsFeed.Summary;
                _newsFeed.Author = newsFeed.Author;
                _newsFeed.YearId = newsFeed.YearId;
                _newsFeed.ValidFrom = newsFeed.ValidFrom;
                _newsFeed.ValidTo = newsFeed.ValidTo;
                _newsFeed.Alberta = newsFeed.Alberta;
                _newsFeed.BritishColumbia = newsFeed.BritishColumbia;
                _newsFeed.Manitoba = newsFeed.Manitoba;
                _newsFeed.NewBrunswick = newsFeed.NewBrunswick;
                _newsFeed.NewfoundlandandLabrador = newsFeed.NewfoundlandandLabrador;
                _newsFeed.NovaScotia = newsFeed.NovaScotia;
                _newsFeed.Nunavut = newsFeed.Nunavut;
                _newsFeed.Ontario = newsFeed.Ontario;
                _newsFeed.PrinceEdwardIsland = newsFeed.PrinceEdwardIsland;
                _newsFeed.Quebec = newsFeed.Quebec;
                _newsFeed.Saskatchewan = newsFeed.Saskatchewan;
                _newsFeed.YukonTerritory = newsFeed.YukonTerritory;
                _newsFeed.NorthwestTerritories = newsFeed.NorthwestTerritories;
                _newsFeed.ModifiedDate = DateTime.Now;
                _newsFeed.ModifiedBy = _userSettings.UserName;

                await _newsFeedRepository.UpdateAsync(_newsFeed);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateNewsFeedAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateNewsFeedAsync(NewsFeedItemViewModel newsFeed)
        {

            _sharedService.WriteLogs("CreateNewsFeedAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _newsFeed = new NewsFeed
                {
                    Title = newsFeed.Title,
                    Text = newsFeed.Text,
                    Summary = newsFeed.Summary,
                    Author = newsFeed.Author,
                    YearId = newsFeed.YearId,
                    ValidFrom = newsFeed.ValidFrom,
                    ValidTo = newsFeed.ValidTo,
                    Alberta = newsFeed.Alberta,
                    BritishColumbia = newsFeed.BritishColumbia,
                    Manitoba = newsFeed.Manitoba,
                    NewBrunswick = newsFeed.NewBrunswick,
                    NewfoundlandandLabrador = newsFeed.NewfoundlandandLabrador,
                    NovaScotia = newsFeed.NovaScotia,
                    Nunavut = newsFeed.Nunavut,
                    Ontario = newsFeed.Ontario,
                    PrinceEdwardIsland = newsFeed.PrinceEdwardIsland,
                    Quebec = newsFeed.Quebec,
                    Saskatchewan = newsFeed.Saskatchewan,
                    YukonTerritory = newsFeed.YukonTerritory,
                    NorthwestTerritories = newsFeed.NorthwestTerritories,
                    CreatedDate = DateTime.Now,
                    CreatedBy = _userSettings.UserName,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = _userSettings.UserName
                };

                await _newsFeedRepository.AddAsync(_newsFeed);
                return _newsFeed.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateNewsFeedAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<NewsFeedItemViewModel> GetNewsFeedItem(int newsFeedId)
        {

            _sharedService.WriteLogs("GetNewsFeedItem started by:" + _userSettings.UserName, true);

            try
            {
                var newsFeed = await _newsFeedRepository.GetByIdAsync(newsFeedId);

                Guard.Against.NullNewsFeed(newsFeedId, newsFeed);

                var vm = new NewsFeedItemViewModel()
                {
                    Id = newsFeed.Id,
                    Title = newsFeed.Title,
                    Text = newsFeed.Text,
                    Summary = newsFeed.Summary,
                    Author = newsFeed.Author,
                    YearId = newsFeed.YearId,
                    ValidFrom = newsFeed.ValidFrom,
                    ValidTo = newsFeed.ValidTo,
                    Alberta = newsFeed.Alberta.HasValue ? newsFeed.Alberta.Value : false,
                    BritishColumbia = newsFeed.BritishColumbia.HasValue ? newsFeed.BritishColumbia.Value : false,
                    Manitoba = newsFeed.Manitoba.HasValue ? newsFeed.Manitoba.Value : false,
                    NewBrunswick = newsFeed.NewBrunswick.HasValue ? newsFeed.NewBrunswick.Value : false,
                    NewfoundlandandLabrador = newsFeed.NewfoundlandandLabrador.HasValue ? newsFeed.NewfoundlandandLabrador.Value : false,
                    NovaScotia = newsFeed.NovaScotia.HasValue ? newsFeed.NovaScotia.Value : false,
                    Nunavut = newsFeed.Nunavut.HasValue ? newsFeed.Nunavut.Value : false,
                    Ontario = newsFeed.Ontario.HasValue ? newsFeed.Ontario.Value : false,
                    PrinceEdwardIsland = newsFeed.PrinceEdwardIsland.HasValue ? newsFeed.PrinceEdwardIsland.Value : false,
                    Quebec = newsFeed.Quebec.HasValue ? newsFeed.Quebec.Value : false,
                    Saskatchewan = newsFeed.Saskatchewan.HasValue ? newsFeed.Saskatchewan.Value : false,
                    YukonTerritory = newsFeed.YukonTerritory.HasValue ? newsFeed.YukonTerritory.Value : false,
                    NorthwestTerritories = newsFeed.NorthwestTerritories.HasValue ? newsFeed.NorthwestTerritories.Value : false,
                    CreatedDate = newsFeed.CreatedDate,
                    CreatedBy = newsFeed.CreatedBy,
                    ModifiedDate = newsFeed.ModifiedDate,
                    ModifiedBy = newsFeed.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetNewsFeedItem failed:" + ex.Message, false);

                var vm = new NewsFeedItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string title)
        {

            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new NewsFeedFilterSpecification(title);

                var totalItems = await _newsFeedRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string title, int id)
        {

            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new NewsFeedFilterSpecification(title, id);

                var totalItems = await _newsFeedRepository.CountAsync(filterSpecification);

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
