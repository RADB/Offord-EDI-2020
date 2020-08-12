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
    public class LanguageService : ILanguageService
    {
        private readonly ILogger<LanguageService> _logger;
        private readonly IAsyncRepository<Language> _languageRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public LanguageService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Language> languageRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<LanguageService>();
            _httpContextAccessor = httpContextAccessor;
            _languageRepository = languageRepository;
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

        public async Task DeleteLanguageAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteLanguageAsync started by:" + _username);

            try
            {
                var language = await _languageRepository.GetByIdAsync(Id);

                Guard.Against.NullLanguage(Id, language);

                await _languageRepository.DeleteAsync(language);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteLanguageAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateLanguageAsync(LanguageItemViewModel language)
        {
            await LogUsername();
            Log.Information("UpdateLanguageAsync started by:" + _username);

            try
            {
                var _language = await _languageRepository.GetByIdAsync(language.Id);

                Guard.Against.NullLanguage(language.Id, _language);

                _language.LanguageCode = language.LanguageCode;
                _language.LanguageEnglish = language.LanguageEnglish;
                _language.LanguageFrench = language.LanguageFrench;
                _language.Sequence = language.Sequence;
                _language.ModifiedDate = DateTime.Now;
                _language.ModifiedBy = _username;

                await _languageRepository.UpdateAsync(_language);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateLanguageAsync failed:" + ex.Message);
            }
        }

        public async Task CreateLanguageAsync(LanguageItemViewModel language)
        {
            await LogUsername();
            Log.Information("CreateLanguageAsync started by:" + _username);

            try
            {
                var _language = new Language();

                _language.LanguageCode = language.LanguageCode;
                _language.LanguageEnglish = language.LanguageEnglish;
                _language.LanguageFrench = language.LanguageFrench;
                _language.Sequence = language.Sequence;
                _language.CreatedDate = DateTime.Now;
                _language.CreatedBy = _username;
                _language.ModifiedDate = DateTime.Now;
                _language.ModifiedBy = _username;

                await _languageRepository.AddAsync(_language);
            }
            catch (Exception ex)
            {
                Log.Error("CreateLanguageAsync failed:" + ex.Message);
            }
        }

        public async Task<LanguageItemViewModel> GetLanguageItem(int languageId)
        {
            await LogUsername();
            Log.Information("GetLanguageItem started by:" + _username);

            try
            {
                var language = await _languageRepository.GetByIdAsync(languageId);

                Guard.Against.NullLanguage(languageId, language);

                var vm = new LanguageItemViewModel()
                {
                    Id = language.Id,
                    LanguageCode = language.LanguageCode,
                    LanguageEnglish = language.LanguageEnglish,
                    LanguageFrench = language.LanguageFrench,
                    Sequence = language.Sequence,
                    CreatedDate = language.CreatedDate,
                    CreatedBy = language.CreatedBy,
                    ModifiedDate = language.ModifiedDate,
                    ModifiedBy = language.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetLanguageItem failed:" + ex.Message);

                var vm = new LanguageItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string languagecode)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new LanguageFilterSpecification(languagecode);

                var totalItems = await _languageRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string languagecode, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new LanguageFilterSpecification(languagecode, id);

                var totalItems = await _languageRepository.CountAsync(filterSpecification);

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
