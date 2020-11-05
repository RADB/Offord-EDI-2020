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

        public LookupSetService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<LookupSet> lookupSetRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
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
        }

        public async Task DeleteLookupSetAsync(int Id)
        {

            Log.Information("DeleteLookupSetAsync started by:" + _userSettings.UserName);

            try
            {
                var lookupSet = await _lookupSetRepository.GetByIdAsync(Id);

                Guard.Against.NullLookupSet(Id, lookupSet);

                await _lookupSetRepository.DeleteAsync(lookupSet);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteLookupSetAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateLookupSetAsync(LookupSetItemViewModel lookupSet)
        {

            Log.Information("UpdateLookupSetAsync started by:" + _userSettings.UserName);

            try
            {
                var _lookupSet = await _lookupSetRepository.GetByIdAsync(lookupSet.Id);

                Guard.Against.NullLookupSet(lookupSet.Id, _lookupSet);

                _lookupSet.LookupName = lookupSet.LookupName;
                _lookupSet.LookupId = lookupSet.LookupId;
                _lookupSet.English = lookupSet.English;
                _lookupSet.French = lookupSet.French;
                _lookupSet.Value = lookupSet.Value;
                _lookupSet.Sequence = lookupSet.Sequence;
                _lookupSet.YearId = lookupSet.YearId;
                _lookupSet.ModifiedDate = DateTime.Now;
                _lookupSet.ModifiedBy = _userSettings.UserName;

                await _lookupSetRepository.UpdateAsync(_lookupSet);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateLookupSetAsync failed:" + ex.Message);
            }
        }

        public async Task CreateLookupSetAsync(LookupSetItemViewModel lookupSet)
        {

            Log.Information("CreateLookupSetAsync started by:" + _userSettings.UserName);

            try
            {
                var _lookupSet = new LookupSet();

                _lookupSet.LookupName = lookupSet.LookupName;
                _lookupSet.LookupId = lookupSet.LookupId;
                _lookupSet.English = lookupSet.English;
                _lookupSet.French = lookupSet.French;
                _lookupSet.Value = lookupSet.Value;
                _lookupSet.Sequence = lookupSet.Sequence;
                _lookupSet.YearId = lookupSet.YearId;
                _lookupSet.CreatedDate = DateTime.Now;
                _lookupSet.CreatedBy = _userSettings.UserName;
                _lookupSet.ModifiedDate = DateTime.Now;
                _lookupSet.ModifiedBy = _userSettings.UserName;

                await _lookupSetRepository.AddAsync(_lookupSet);
            }
            catch (Exception ex)
            {
                Log.Error("CreateLookupSetAsync failed:" + ex.Message);
            }
        }

        public async Task<LookupSetItemViewModel> GetLookupSetItem(int lookupSetId)
        {

            Log.Information("GetLookupSetItem started by:" + _userSettings.UserName);

            try
            {
                var lookupSet = await _lookupSetRepository.GetByIdAsync(lookupSetId);

                Guard.Against.NullLookupSet(lookupSetId, lookupSet);

                var vm = new LookupSetItemViewModel()
                {
                    Id = lookupSet.Id,
                    LookupId = lookupSet.LookupId,
                    LookupName = lookupSet.LookupName,
                    English = lookupSet.English,
                    French = lookupSet.French,
                    Value = lookupSet.Value,
                    Sequence = lookupSet.Sequence,
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
                Log.Error("GetLookupSetItem failed:" + ex.Message);

                var vm = new LookupSetItemViewModel();

                return vm;
            }
        }
    }
}
