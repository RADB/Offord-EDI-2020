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
    public class LookupSetService : ILookupSetService
    {
        private readonly ILogger<LookupSetService> _logger;
        private readonly IAsyncRepository<LookupSet> _lookupSetRepository;
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

        public LookupSetService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<LookupSet> lookupSetRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<LookupSetService>();
            _httpContextAccessor = httpContextAccessor;
            _lookupSetRepository = lookupSetRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteLookupSetAsync(int Id)
        {

            _sharedService.WriteLogs("DeleteLookupSetAsync started by:" + _userSettings.UserName, true);

            try
            {
                var lookupSet = await _lookupSetRepository.GetByIdAsync(Id);

                Guard.Against.NullLookupSet(Id, lookupSet);

                await _lookupSetRepository.DeleteAsync(lookupSet);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteLookupSetAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateLookupSetAsync(LookupSetItemViewModel lookupSet)
        {

            _sharedService.WriteLogs("UpdateLookupSetAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _lookupSet = await _lookupSetRepository.GetByIdAsync(lookupSet.Id);

                Guard.Against.NullLookupSet(lookupSet.Id, _lookupSet);

                _lookupSet.LookupName = lookupSet.LookupName;
                _lookupSet.YearId = lookupSet.YearId;
                _lookupSet.ModifiedDate = DateTime.Now;
                _lookupSet.ModifiedBy = _userSettings.UserName;

                await _lookupSetRepository.UpdateAsync(_lookupSet);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateLookupSetAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateLookupSetAsync(LookupSetItemViewModel lookupSet)
        {

            _sharedService.WriteLogs("CreateLookupSetAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _lookupSet = new LookupSet();

                _lookupSet.LookupName = lookupSet.LookupName;
                _lookupSet.YearId = lookupSet.YearId;
                _lookupSet.CreatedDate = DateTime.Now;
                _lookupSet.CreatedBy = _userSettings.UserName;
                _lookupSet.ModifiedDate = DateTime.Now;
                _lookupSet.ModifiedBy = _userSettings.UserName;

                await _lookupSetRepository.AddAsync(_lookupSet);
                return _lookupSet.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateLookupSetAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<LookupSetItemViewModel> GetLookupSetItem(int lookupSetId)
        {

            _sharedService.WriteLogs("GetLookupSetItem started by:" + _userSettings.UserName, true);

            try
            {
                var lookupSet = await _lookupSetRepository.GetByIdAsync(lookupSetId);

                Guard.Against.NullLookupSet(lookupSetId, lookupSet);

                var vm = new LookupSetItemViewModel()
                {
                    Id = lookupSet.Id,
                    LookupName = lookupSet.LookupName,
                    YearId = lookupSet.YearId,
                    CreatedDate = lookupSet.CreatedDate,
                    CreatedBy = lookupSet.CreatedBy,
                    ModifiedDate = lookupSet.ModifiedDate,
                    ModifiedBy = lookupSet.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetLookupSetItem failed:" + ex.Message, false);

                var vm = new LookupSetItemViewModel();

                return vm;
            }
        }
    }
}
