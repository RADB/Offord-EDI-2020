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
    public class TranslationService : ITranslationService
    {
        private readonly ILogger<TranslationService> _logger;
        private readonly IAsyncRepository<Translation> _translationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public TranslationService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Translation> translationRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<TranslationService>();
            _httpContextAccessor = httpContextAccessor;
            _translationRepository = translationRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteTranslationAsync(int Id)
        {

            Log.Information("DeleteTranslationAsync started by:" + _userSettings.UserName);

            try
            {
                var translation = await _translationRepository.GetByIdAsync(Id);

                Guard.Against.NullTranslation(Id, translation);

                await _translationRepository.DeleteAsync(translation);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteTranslationAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateTranslationAsync(TranslationItemViewModel translation)
        {

            Log.Information("UpdateTranslationAsync started by:" + _userSettings.UserName);

            try
            {
                var _translation = await _translationRepository.GetByIdAsync(translation.Id);

                Guard.Against.NullTranslation(translation.Id, _translation);

                _translation.English = translation.English;
                _translation.French = translation.French;
                _translation.ModifiedDate = DateTime.Now;
                _translation.ModifiedBy = _userSettings.UserName;

                await _translationRepository.UpdateAsync(_translation);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateTranslationAsync failed:" + ex.Message);
            }
        }

        public async Task CreateTranslationAsync(TranslationItemViewModel translation)
        {

            Log.Information("CreateTranslationAsync started by:" + _userSettings.UserName);

            try
            {
                var _translation = new Translation();

                _translation.English = translation.English;
                _translation.French = translation.French;
                _translation.CreatedDate = DateTime.Now;
                _translation.CreatedBy = _userSettings.UserName;
                _translation.ModifiedDate = DateTime.Now;
                _translation.ModifiedBy = _userSettings.UserName;

                await _translationRepository.AddAsync(_translation);
            }
            catch (Exception ex)
            {
                Log.Error("CreateTranslationAsync failed:" + ex.Message);
            }
        }

        public async Task<TranslationItemViewModel> GetTranslationItem(int translationId)
        {

            Log.Information("GetTranslationItem started by:" + _userSettings.UserName);

            try
            {
                var translation = await _translationRepository.GetByIdAsync(translationId);

                Guard.Against.NullTranslation(translationId, translation);

                var vm = new TranslationItemViewModel()
                {
                    Id = translation.Id,
                    English = translation.English,
                    French = translation.French,
                    CreatedDate = translation.CreatedDate,
                    CreatedBy = translation.CreatedBy,
                    ModifiedDate = translation.ModifiedDate,
                    ModifiedBy = translation.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetTranslationItem failed:" + ex.Message);

                var vm = new TranslationItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string english)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new TranslationFilterSpecification(english);

                var totalItems = await _translationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string english, int id)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new TranslationFilterSpecification(english, id);

                var totalItems = await _translationRepository.CountAsync(filterSpecification);

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
