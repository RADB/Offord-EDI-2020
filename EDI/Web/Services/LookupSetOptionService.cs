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
    public class LookupSetOptionService : ILookupSetOptionService
    {
        private readonly ILogger<LookupSetOptionService> _logger;
        private readonly IAsyncRepository<LookupSetOption> _lookupSetRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public LookupSetOptionService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<LookupSetOption> lookupSetRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<LookupSetOptionService>();
            _httpContextAccessor = httpContextAccessor;
            _lookupSetRepository = lookupSetRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteLookupSetOptionAsync(int Id)
        {

            Log.Information("DeleteLookupSetOptionAsync started by:" + _userSettings.UserName);

            try
            {
                var lookupSet = await _lookupSetRepository.GetByIdAsync(Id);

                Guard.Against.NullLookupSetOption(Id, lookupSet);

                await _lookupSetRepository.DeleteAsync(lookupSet);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteLookupSetOptionAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateLookupSetOptionAsync(LookupSetOptionItemViewModel lookupSet)
        {

            Log.Information("UpdateLookupSetOptionAsync started by:" + _userSettings.UserName);

            try
            {
                var _lookupSet = await _lookupSetRepository.GetByIdAsync(lookupSet.Id);

                Guard.Against.NullLookupSetOption(lookupSet.Id, _lookupSet);

                _lookupSet.LookupId = lookupSet.LookupId;
                _lookupSet.English = lookupSet.English;
                _lookupSet.French = lookupSet.French;
                _lookupSet.Value = lookupSet.Value;
                _lookupSet.Sequence = lookupSet.Sequence;
                //_lookupSet.YearId = lookupSet.YearId;
                _lookupSet.ModifiedDate = DateTime.Now;
                _lookupSet.ModifiedBy = _userSettings.UserName;

                await _lookupSetRepository.UpdateAsync(_lookupSet);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateLookupSetOptionAsync failed:" + ex.Message);
            }
        }

        public async Task CreateLookupSetOptionAsync(LookupSetOptionItemViewModel lookupSet)
        {

            Log.Information("CreateLookupSetOptionAsync started by:" + _userSettings.UserName);

            try
            {
                var _lookupSet = new LookupSetOption();

                _lookupSet.LookupId = lookupSet.LookupId;
                _lookupSet.English = lookupSet.English;
                _lookupSet.French = lookupSet.French;
                _lookupSet.Value = lookupSet.Value;
                _lookupSet.Sequence = lookupSet.Sequence;
               // _lookupSet.YearId = lookupSet.YearId;
                _lookupSet.CreatedDate = DateTime.Now;
                _lookupSet.CreatedBy = _userSettings.UserName;
                _lookupSet.ModifiedDate = DateTime.Now;
                _lookupSet.ModifiedBy = _userSettings.UserName;

                await _lookupSetRepository.AddAsync(_lookupSet);
            }
            catch (Exception ex)
            {
                Log.Error("CreateLookupSetOptionAsync failed:" + ex.Message);
            }
        }

        public async Task<LookupSetOptionItemViewModel> GetLookupSetOptionItem(int lookupSetId)
        {

            Log.Information("GetLookupSetOptionItem started by:" + _userSettings.UserName);

            try
            {
                var lookupSet = await _lookupSetRepository.GetByIdAsync(lookupSetId);

                Guard.Against.NullLookupSetOption(lookupSetId, lookupSet);

                var vm = new LookupSetOptionItemViewModel()
                {
                    Id = lookupSet.Id,
                    LookupId = lookupSet.LookupId,
                    English = lookupSet.English,
                    French = lookupSet.French,
                    Value = lookupSet.Value,
                    Sequence = lookupSet.Sequence,
                    //YearId = lookupSet.YearId,
                    CreatedDate = lookupSet.CreatedDate,
                    CreatedBy = lookupSet.CreatedBy,
                    ModifiedDate = lookupSet.ModifiedDate,
                    ModifiedBy = lookupSet.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetLookupSetOptionItem failed:" + ex.Message);

                var vm = new LookupSetOptionItemViewModel();

                return vm;
            }
        }
    }
}
