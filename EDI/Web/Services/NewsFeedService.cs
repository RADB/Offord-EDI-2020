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

        public NewsFeedService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<NewsFeed> newsFeedRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
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
        }

        public async Task DeleteNewsFeedAsync(int Id)
        {

            Log.Information("DeleteNewsFeedAsync started by:" + _userSettings.UserName);

            try
            {
                var newsFeed = await _newsFeedRepository.GetByIdAsync(Id);

                Guard.Against.NullNewsFeed(Id, newsFeed);

                await _newsFeedRepository.DeleteAsync(newsFeed);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteNewsFeedAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateNewsFeedAsync(NewsFeedItemViewModel newsFeed)
        {

            Log.Information("UpdateNewsFeedAsync started by:" + _userSettings.UserName);

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
                _newsFeed.ModifiedDate = DateTime.Now;
                _newsFeed.ModifiedBy = _userSettings.UserName;

                await _newsFeedRepository.UpdateAsync(_newsFeed);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateNewsFeedAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateNewsFeedAsync(NewsFeedItemViewModel newsFeed)
        {

            Log.Information("CreateNewsFeedAsync started by:" + _userSettings.UserName);

            try
            {
                var _newsFeed = new NewsFeed();

                _newsFeed.Title = newsFeed.Title;
                _newsFeed.Text = newsFeed.Text;
                _newsFeed.Summary = newsFeed.Summary;
                _newsFeed.Author = newsFeed.Author;
                _newsFeed.YearId = newsFeed.YearId;
                _newsFeed.ValidFrom = newsFeed.ValidFrom;
                _newsFeed.ValidTo = newsFeed.ValidTo;
                _newsFeed.CreatedDate = DateTime.Now;
                _newsFeed.CreatedBy = _userSettings.UserName;
                _newsFeed.ModifiedDate = DateTime.Now;
                _newsFeed.ModifiedBy = _userSettings.UserName;

                await _newsFeedRepository.AddAsync(_newsFeed);
                return _newsFeed.Id;
            }
            catch (Exception ex)
            {
                Log.Error("CreateNewsFeedAsync failed:" + ex.Message);
                return 0;
            }
        }

        public async Task<NewsFeedItemViewModel> GetNewsFeedItem(int newsFeedId)
        {

            Log.Information("GetNewsFeedItem started by:" + _userSettings.UserName);

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
                    CreatedDate = newsFeed.CreatedDate,
                    CreatedBy = newsFeed.CreatedBy,
                    ModifiedDate = newsFeed.ModifiedDate,
                    ModifiedBy = newsFeed.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetNewsFeedItem failed:" + ex.Message);

                var vm = new NewsFeedItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string title)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new NewsFeedFilterSpecification(title);

                var totalItems = await _newsFeedRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string title, int id)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new NewsFeedFilterSpecification(title, id);

                var totalItems = await _newsFeedRepository.CountAsync(filterSpecification);

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
