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
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly ILogger<QuestionnaireService> _logger;
        private readonly IAsyncRepository<Questionnaire> _questionnaireRepository;
        private readonly IAsyncRepository<QuestionnairesDataDemographic> _questionnairesDataDemographic;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public QuestionnaireService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Questionnaire> questionnaireRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<QuestionnaireService>();
            _httpContextAccessor = httpContextAccessor;
            _questionnaireRepository = questionnaireRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteQuestionnaireAsync(int Id)
        {

            Log.Information("DeleteQuestionnaireAsync started by:" + _userSettings.UserName);

            try
            {
                var questionnaire = await _questionnaireRepository.GetByIdAsync(Id);

                Guard.Against.NullQuestionnaire(Id, questionnaire);

                await _questionnaireRepository.DeleteAsync(questionnaire);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteQuestionnaireAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateQuestionnaireAsync(QuestionnaireItemViewModel questionnaire)
        {

            Log.Information("UpdateQuestionnaireAsync started by:" + _userSettings.UserName);

            try
            {
                var _questionnaire = await _questionnaireRepository.GetByIdAsync(questionnaire.Id);

                Guard.Against.NullQuestionnaire(questionnaire.Id, _questionnaire);

                _questionnaire.English = questionnaire.English;
                _questionnaire.French = questionnaire.French;
                _questionnaire.QuestionnaireName = questionnaire.QuestionnaireName;
                _questionnaire.DescriptionEnglish = questionnaire.DescriptionEnglish;
                _questionnaire.DescriptionFrench = questionnaire.DescriptionFrench;
                _questionnaire.YearId = questionnaire.YearId;
                _questionnaire.ShowProgressBar = questionnaire.ShowProgressBar;
                _questionnaire.ShowQuestionNumbers = questionnaire.ShowQuestionNumbers;
                _questionnaire.ModifiedDate = DateTime.Now;
                _questionnaire.ModifiedBy = _userSettings.UserName;

                await _questionnaireRepository.UpdateAsync(_questionnaire);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateQuestionnaireAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateQuestionnaireAsync(QuestionnaireItemViewModel questionnaire)
        {

            Log.Information("CreateQuestionnaireAsync started by:" + _userSettings.UserName);

            try
            {
                var _questionnaire = new Questionnaire();

                _questionnaire.English = questionnaire.English;
                _questionnaire.French = questionnaire.French;
                _questionnaire.QuestionnaireName = questionnaire.QuestionnaireName;
                _questionnaire.DescriptionEnglish = questionnaire.DescriptionEnglish;
                _questionnaire.DescriptionFrench = questionnaire.DescriptionFrench;
                _questionnaire.YearId = questionnaire.YearId;
                _questionnaire.ShowProgressBar = questionnaire.ShowProgressBar;
                _questionnaire.ShowQuestionNumbers = questionnaire.ShowQuestionNumbers;
                _questionnaire.CreatedDate = DateTime.Now;
                _questionnaire.CreatedBy = _userSettings.UserName;
                _questionnaire.ModifiedDate = DateTime.Now;
                _questionnaire.ModifiedBy = _userSettings.UserName;

                await _questionnaireRepository.AddAsync(_questionnaire);
                return _questionnaire.Id;
            }
            catch (Exception ex)
            {
                Log.Error("CreateQuestionnaireAsync failed:" + ex.Message);
                return 0;
            }
        }

        public async Task<QuestionnaireItemViewModel> GetQuestionnaireItem(int questionnaireId)
        {

            Log.Information("GetQuestionnaireItem started by:" + _userSettings.UserName);

            try
            {
                var questionnaire = await _questionnaireRepository.GetByIdAsync(questionnaireId);

                Guard.Against.NullQuestionnaire(questionnaireId, questionnaire);

                var vm = new QuestionnaireItemViewModel()
                {
                    Id = questionnaire.Id,
                    English = questionnaire.English,
                    French = questionnaire.French,
                    QuestionnaireName = questionnaire.QuestionnaireName,
                    DescriptionEnglish = questionnaire.DescriptionEnglish,
                    DescriptionFrench = questionnaire.DescriptionFrench,
                    YearId = questionnaire.YearId,
                    ShowProgressBar = questionnaire.ShowProgressBar,
                    ShowQuestionNumbers = questionnaire.ShowQuestionNumbers,
                    CreatedDate = questionnaire.CreatedDate,
                    CreatedBy = questionnaire.CreatedBy,
                    ModifiedDate = questionnaire.ModifiedDate,
                    ModifiedBy = questionnaire.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetQuestionnaireItem failed:" + ex.Message);

                var vm = new QuestionnaireItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string name)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new QuestionnaireFilterSpecification(name);

                var totalItems = await _questionnaireRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string name, int id)
        {

            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new QuestionnaireFilterSpecification(name, id);

                var totalItems = await _questionnaireRepository.CountAsync(filterSpecification);

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
