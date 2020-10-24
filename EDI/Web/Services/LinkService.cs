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

        public LinkService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Link> linkRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
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
        }

        public async Task DeleteLinkAsync(int Id)
        {

            Log.Information("DeleteLinkAsync started by:" + _userSettings.UserName);

            try
            {
                var link = await _linkRepository.GetByIdAsync(Id);

                Guard.Against.NullLink(Id, link);

                await _linkRepository.DeleteAsync(link);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteLinkAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateLinkAsync(LinkItemViewModel link)
        {

            Log.Information("UpdateLinkAsync started by:" + _userSettings.UserName);

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
                _link.ModifiedDate = DateTime.Now;
                _link.ModifiedBy = _userSettings.UserName;

                await _linkRepository.UpdateAsync(_link);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateLinkAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateLinkAsync(LinkItemViewModel link)
        {

            Log.Information("CreateLinkAsync started by:" + _userSettings.UserName);

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
                _link.CreatedDate = DateTime.Now;
                _link.CreatedBy = _userSettings.UserName;
                _link.ModifiedDate = DateTime.Now;
                _link.ModifiedBy = _userSettings.UserName;

                await _linkRepository.AddAsync(_link);
                return _link.Id;
            }
            catch (Exception ex)
            {
                Log.Error("CreateLinkAsync failed:" + ex.Message);
                return 0;
            }
        }

        public async Task<LinkItemViewModel> GetLinkItem(int linkId)
        {

            Log.Information("GetLinkItem started by:" + _userSettings.UserName);

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
                    CreatedDate = link.CreatedDate,
                    CreatedBy = link.CreatedBy,
                    ModifiedDate = link.ModifiedDate,
                    ModifiedBy = link.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetLinkItem failed:" + ex.Message);

                var vm = new LinkItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string url)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new LinkFilterSpecification(url);

                var totalItems = await _linkRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string url, int id)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new LinkFilterSpecification(url, id);

                var totalItems = await _linkRepository.CountAsync(filterSpecification);

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
