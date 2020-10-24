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
    public class FaqService : IFaqService
    {
        private readonly ILogger<FaqService> _logger;
        private readonly IAsyncRepository<Faq> _faqRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public FaqService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Faq> faqRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<FaqService>();
            _httpContextAccessor = httpContextAccessor;
            _faqRepository = faqRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteFaqAsync(int Id)
        {

            Log.Information("DeleteFaqAsync started by:" + _userSettings.UserName);

            try
            {
                var faq = await _faqRepository.GetByIdAsync(Id);

                Guard.Against.NullFaq(Id, faq);

                await _faqRepository.DeleteAsync(faq);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteFaqAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateFaqAsync(FaqItemViewModel faq)
        {

            Log.Information("UpdateFaqAsync started by:" + _userSettings.UserName);

            try
            {
                var _faq = await _faqRepository.GetByIdAsync(faq.Id);

                Guard.Against.NullFaq(faq.Id, _faq);

                _faq.Question = string.IsNullOrEmpty(faq.Question) ? null : faq.Question.Trim();
                _faq.Answer = string.IsNullOrEmpty(faq.Answer) ? null : faq.Answer.Trim();
                _faq.IsAdministratorFaq = faq.IsAdministratorFaq;
                _faq.IsCoordinatorFaq = faq.IsCoordinatorFaq;
                _faq.IsTeacherFaq = faq.IsTeacherFaq;
                _faq.Sequence = faq.Sequence;
                _faq.YearId = faq.YearId;
                _faq.ModifiedDate = DateTime.Now;
                _faq.ModifiedBy = _userSettings.UserName;

                await _faqRepository.UpdateAsync(_faq);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateFaqAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateFaqAsync(FaqItemViewModel faq)
        {

            Log.Information("CreateFaqAsync started by:" + _userSettings.UserName);

            try
            {
                var _faq = new Faq();

                _faq.Question = string.IsNullOrEmpty(faq.Question) ? null : faq.Question.Trim();
                _faq.Answer = string.IsNullOrEmpty(faq.Answer) ? null : faq.Answer.Trim();
                _faq.IsAdministratorFaq = faq.IsAdministratorFaq;
                _faq.IsCoordinatorFaq = faq.IsCoordinatorFaq;
                _faq.IsTeacherFaq = faq.IsTeacherFaq;
                _faq.Sequence = faq.Sequence;
                _faq.YearId = faq.YearId;
                _faq.CreatedDate = DateTime.Now;
                _faq.CreatedBy = _userSettings.UserName;
                _faq.ModifiedDate = DateTime.Now;
                _faq.ModifiedBy = _userSettings.UserName;

                await _faqRepository.AddAsync(_faq);
                return _faq.Id;
            }
            catch (Exception ex)
            {
                Log.Error("CreateFaqAsync failed:" + ex.Message);
                return 0;
            }
        }

        public async Task<FaqItemViewModel> GetFaqItem(int faqId)
        {

            Log.Information("GetFaqItem started by:" + _userSettings.UserName);

            try
            {
                var faq = await _faqRepository.GetByIdAsync(faqId);

                Guard.Against.NullFaq(faqId, faq);

                var vm = new FaqItemViewModel()
                {
                    Id = faq.Id,
                    Question = faq.Question,
                    Answer = faq.Answer,
                    IsAdministratorFaq = faq.IsAdministratorFaq,
                    IsCoordinatorFaq = faq.IsCoordinatorFaq,
                    IsTeacherFaq = faq.IsTeacherFaq,
                    Sequence = faq.Sequence,
                    YearId = faq.YearId,
                    CreatedDate = faq.CreatedDate,
                    CreatedBy = faq.CreatedBy,
                    ModifiedDate = faq.ModifiedDate,
                    ModifiedBy = faq.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetFaqItem failed:" + ex.Message);

                var vm = new FaqItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string question)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new FaqFilterSpecification(question);

                var totalItems = await _faqRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string question, int id)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new FaqFilterSpecification(question, id);

                var totalItems = await _faqRepository.CountAsync(filterSpecification);

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
