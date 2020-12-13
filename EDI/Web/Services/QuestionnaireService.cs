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
        private readonly IAsyncRepository<QuestionnairesConfiguration> _questionnairesConfigurationRepository;
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
            IAsyncRepository<QuestionnairesConfiguration> questionnairesConfigurationRepository,
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
            _questionnairesConfigurationRepository = questionnairesConfigurationRepository;
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

        public async Task DeleteQuestionnaireConfiguarionAsync(int Id)
        {

            Log.Information("DeleteQuestionnaireConfiguarionAsync started by:" + _userSettings.UserName);

            try
            {
                var qc = await _questionnairesConfigurationRepository.GetByIdAsync(Id);

                Guard.Against.NullQuestionnaireConfiguration(Id, qc);

                await _questionnairesConfigurationRepository.DeleteAsync(qc);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteQuestionnaireConfiguarionAsync failed:" + ex.Message);
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

        public async Task UpdateQuestionnaireConfigurationAsync(QuestionnaireConfigurationItemViewModel questionnaireConfiguration)
        {

            Log.Information("UpdateQuestionnaireConfigurationAsync started by:" + _userSettings.UserName);

            try
            {
                var _questionnaireConfiguration = await _questionnairesConfigurationRepository.GetByIdAsync(questionnaireConfiguration.Id);

                Guard.Against.NullQuestionnaireConfiguration(questionnaireConfiguration.Id, _questionnaireConfiguration);

                _questionnaireConfiguration.Id = questionnaireConfiguration.Id;
                _questionnaireConfiguration.QuestionNumber = questionnaireConfiguration.QuestionNumber;
                _questionnaireConfiguration.EntityName = questionnaireConfiguration.EntityName;
                _questionnaireConfiguration.EntityField = questionnaireConfiguration.EntityField;
                _questionnaireConfiguration.VariableName = questionnaireConfiguration.VariableName;
                _questionnaireConfiguration.English = questionnaireConfiguration.English;
                _questionnaireConfiguration.French = questionnaireConfiguration.French;
                _questionnaireConfiguration.HasHelp = questionnaireConfiguration.HasHelp;
                _questionnaireConfiguration.HelpText = questionnaireConfiguration.HelpText;
                _questionnaireConfiguration.HelpTextFrench = questionnaireConfiguration.HelpTextFrench;
                _questionnaireConfiguration.GroupName = questionnaireConfiguration.GroupName;
                _questionnaireConfiguration.ShowGroupName = questionnaireConfiguration.ShowGroupName;
                _questionnaireConfiguration.Sequence = questionnaireConfiguration.Sequence;
                _questionnaireConfiguration.IsRequired = questionnaireConfiguration.IsRequired;
                _questionnaireConfiguration.IsConditional = questionnaireConfiguration.IsConditional;
                _questionnaireConfiguration.Condition = questionnaireConfiguration.Condition;
                _questionnaireConfiguration.IsReadOnly = questionnaireConfiguration.IsReadOnly;
                _questionnaireConfiguration.HasNotification = questionnaireConfiguration.HasNotification;
                _questionnaireConfiguration.NotificationCondition = questionnaireConfiguration.NotificationCondition;
                _questionnaireConfiguration.Notification = questionnaireConfiguration.Notification;
                _questionnaireConfiguration.NotificationFrench = questionnaireConfiguration.NotificationFrench;
                _questionnaireConfiguration.InputTypeId = questionnaireConfiguration.InputTypeId;
                _questionnaireConfiguration.IsHeader = questionnaireConfiguration.IsHeader;
                _questionnaireConfiguration.Mask = questionnaireConfiguration.Mask;
                _questionnaireConfiguration.OrientationId = questionnaireConfiguration.OrientationId;
                _questionnaireConfiguration.Columns = questionnaireConfiguration.Columns;
                _questionnaireConfiguration.HasLookupEntity = questionnaireConfiguration.HasLookupEntity;
                _questionnaireConfiguration.LookupEntityId = questionnaireConfiguration.LookupEntityId;
                _questionnaireConfiguration.Alberta = questionnaireConfiguration.Alberta;
                _questionnaireConfiguration.BritishColumbia = questionnaireConfiguration.BritishColumbia;
                _questionnaireConfiguration.Manitoba = questionnaireConfiguration.Manitoba;
                _questionnaireConfiguration.NewBrunswick = questionnaireConfiguration.NewBrunswick;
                _questionnaireConfiguration.NewfoundlandandLabrador = questionnaireConfiguration.NewfoundlandandLabrador;
                _questionnaireConfiguration.NovaScotia = questionnaireConfiguration.NovaScotia;
                _questionnaireConfiguration.Nunavut = questionnaireConfiguration.Nunavut;
                _questionnaireConfiguration.Ontario = questionnaireConfiguration.Ontario;
                _questionnaireConfiguration.PrinceEdwardIsland = questionnaireConfiguration.PrinceEdwardIsland;
                _questionnaireConfiguration.Quebec = questionnaireConfiguration.Quebec;
                _questionnaireConfiguration.Saskatchewan = questionnaireConfiguration.Saskatchewan;
                _questionnaireConfiguration.YukonTerritory = questionnaireConfiguration.YukonTerritory;
                _questionnaireConfiguration.NorthwestTerritories = questionnaireConfiguration.NorthwestTerritories;
                _questionnaireConfiguration.ModifiedDate = DateTime.Now;
                _questionnaireConfiguration.ModifiedBy = _userSettings.UserName;

                await _questionnairesConfigurationRepository.UpdateAsync(_questionnaireConfiguration);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateQuestionnaireConfigurationAsync failed:" + ex.Message);
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

        public async Task<int> CreateQuestionnaireConfigurationAsync(QuestionnaireConfigurationItemViewModel questionnaireConfiguration)
        {

            Log.Information("CreateQuestionnaireConfigurationAsync started by:" + _userSettings.UserName);

            try
            {
                var _questionnaireConfiguration = new QuestionnairesConfiguration();

                _questionnaireConfiguration.Id = questionnaireConfiguration.Id;
                _questionnaireConfiguration.QuestionNumber = questionnaireConfiguration.QuestionNumber;
                _questionnaireConfiguration.EntityName = questionnaireConfiguration.EntityName;
                _questionnaireConfiguration.EntityField = questionnaireConfiguration.EntityField;
                _questionnaireConfiguration.VariableName = questionnaireConfiguration.VariableName;
                _questionnaireConfiguration.English = questionnaireConfiguration.English;
                _questionnaireConfiguration.French = questionnaireConfiguration.French;
                _questionnaireConfiguration.HasHelp = questionnaireConfiguration.HasHelp;
                _questionnaireConfiguration.HelpText = questionnaireConfiguration.HelpText;
                _questionnaireConfiguration.HelpTextFrench = questionnaireConfiguration.HelpTextFrench;
                _questionnaireConfiguration.GroupName = questionnaireConfiguration.GroupName;
                _questionnaireConfiguration.ShowGroupName = questionnaireConfiguration.ShowGroupName;
                _questionnaireConfiguration.Sequence = questionnaireConfiguration.Sequence;
                _questionnaireConfiguration.IsRequired = questionnaireConfiguration.IsRequired;
                _questionnaireConfiguration.IsConditional = questionnaireConfiguration.IsConditional;
                _questionnaireConfiguration.Condition = questionnaireConfiguration.Condition;
                _questionnaireConfiguration.IsReadOnly = questionnaireConfiguration.IsReadOnly;
                _questionnaireConfiguration.HasNotification = questionnaireConfiguration.HasNotification;
                _questionnaireConfiguration.NotificationCondition = questionnaireConfiguration.NotificationCondition;
                _questionnaireConfiguration.Notification = questionnaireConfiguration.Notification;
                _questionnaireConfiguration.NotificationFrench = questionnaireConfiguration.NotificationFrench;
                _questionnaireConfiguration.InputTypeId = questionnaireConfiguration.InputTypeId;
                _questionnaireConfiguration.IsHeader = questionnaireConfiguration.IsHeader;
                _questionnaireConfiguration.Mask = questionnaireConfiguration.Mask;
                _questionnaireConfiguration.OrientationId = questionnaireConfiguration.OrientationId;
                _questionnaireConfiguration.Columns = questionnaireConfiguration.Columns;
                _questionnaireConfiguration.HasLookupEntity = questionnaireConfiguration.HasLookupEntity;
                _questionnaireConfiguration.LookupEntityId = questionnaireConfiguration.LookupEntityId;
                _questionnaireConfiguration.Alberta = questionnaireConfiguration.Alberta;
                _questionnaireConfiguration.BritishColumbia = questionnaireConfiguration.BritishColumbia;
                _questionnaireConfiguration.Manitoba = questionnaireConfiguration.Manitoba;
                _questionnaireConfiguration.NewBrunswick = questionnaireConfiguration.NewBrunswick;
                _questionnaireConfiguration.NewfoundlandandLabrador = questionnaireConfiguration.NewfoundlandandLabrador;
                _questionnaireConfiguration.NovaScotia = questionnaireConfiguration.NovaScotia;
                _questionnaireConfiguration.Nunavut = questionnaireConfiguration.Nunavut;
                _questionnaireConfiguration.Ontario = questionnaireConfiguration.Ontario;
                _questionnaireConfiguration.PrinceEdwardIsland = questionnaireConfiguration.PrinceEdwardIsland;
                _questionnaireConfiguration.Quebec = questionnaireConfiguration.Quebec;
                _questionnaireConfiguration.Saskatchewan = questionnaireConfiguration.Saskatchewan;
                _questionnaireConfiguration.YukonTerritory = questionnaireConfiguration.YukonTerritory;
                _questionnaireConfiguration.NorthwestTerritories = questionnaireConfiguration.NorthwestTerritories;
                _questionnaireConfiguration.ModifiedDate = DateTime.Now;
                _questionnaireConfiguration.ModifiedBy = _userSettings.UserName;
                _questionnaireConfiguration.CreatedDate = DateTime.Now;
                _questionnaireConfiguration.CreatedBy = _userSettings.UserName;

                await _questionnairesConfigurationRepository.AddAsync(_questionnaireConfiguration);
                return _questionnaireConfiguration.Id;
            }
            catch (Exception ex)
            {
                Log.Error("CreateQuestionnaireConfigurationAsync failed:" + ex.Message);
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

        public async Task<QuestionnaireConfigurationItemViewModel> GetQuestionnaireConfigurationItem(int questionnaireConfigurationId)
        {

            Log.Information("GetQuestionnaireConfigurationItem started by:" + _userSettings.UserName);

            try
            {
                var questionnaireConfiguration = await _questionnairesConfigurationRepository.GetByIdAsync(questionnaireConfigurationId);

                Guard.Against.NullQuestionnaireConfiguration(questionnaireConfigurationId, questionnaireConfiguration);

                var vm = new QuestionnaireConfigurationItemViewModel()
                {
                    Id = questionnaireConfiguration.Id,
                    QuestionNumber = questionnaireConfiguration.QuestionNumber,
                    EntityName = questionnaireConfiguration.EntityName,
                    EntityField = questionnaireConfiguration.EntityField,
                    VariableName = questionnaireConfiguration.VariableName,
                    English = questionnaireConfiguration.English,
                    French = questionnaireConfiguration.French,
                    HasHelp = questionnaireConfiguration.HasHelp,
                    HelpText = questionnaireConfiguration.HelpText,
                    HelpTextFrench = questionnaireConfiguration.HelpTextFrench,
                    GroupName = questionnaireConfiguration.GroupName,
                    ShowGroupName = questionnaireConfiguration.ShowGroupName,
                    Sequence = questionnaireConfiguration.Sequence,
                    IsRequired = questionnaireConfiguration.IsRequired,
                    IsConditional = questionnaireConfiguration.IsConditional,
                    Condition = questionnaireConfiguration.Condition,
                    IsReadOnly = questionnaireConfiguration.IsReadOnly,
                    HasNotification = questionnaireConfiguration.HasNotification,
                    NotificationCondition = questionnaireConfiguration.NotificationCondition,
                    Notification = questionnaireConfiguration.Notification,
                    NotificationFrench = questionnaireConfiguration.NotificationFrench,
                    InputTypeId = questionnaireConfiguration.InputTypeId,
                    IsHeader = questionnaireConfiguration.IsHeader,
                    Mask = questionnaireConfiguration.Mask,
                    OrientationId = questionnaireConfiguration.OrientationId,
                    Columns = questionnaireConfiguration.Columns,
                    HasLookupEntity = questionnaireConfiguration.HasLookupEntity,
                    LookupEntityId = questionnaireConfiguration.LookupEntityId,
                    Alberta = questionnaireConfiguration.Alberta.HasValue ? questionnaireConfiguration.Alberta.Value : false,
                    BritishColumbia = questionnaireConfiguration.BritishColumbia.HasValue ? questionnaireConfiguration.BritishColumbia.Value : false,
                    Manitoba = questionnaireConfiguration.Manitoba.HasValue ? questionnaireConfiguration.Manitoba.Value : false,
                    NewBrunswick = questionnaireConfiguration.NewBrunswick.HasValue ? questionnaireConfiguration.NewBrunswick.Value : false,
                    NewfoundlandandLabrador = questionnaireConfiguration.NewfoundlandandLabrador.HasValue ? questionnaireConfiguration.NewfoundlandandLabrador.Value : false,
                    NovaScotia = questionnaireConfiguration.NovaScotia.HasValue ? questionnaireConfiguration.NovaScotia.Value : false,
                    Nunavut = questionnaireConfiguration.Nunavut.HasValue ? questionnaireConfiguration.Nunavut.Value : false,
                    Ontario = questionnaireConfiguration.Ontario.HasValue ? questionnaireConfiguration.Ontario.Value : false,
                    PrinceEdwardIsland = questionnaireConfiguration.PrinceEdwardIsland.HasValue ? questionnaireConfiguration.PrinceEdwardIsland.Value : false,
                    Quebec = questionnaireConfiguration.Quebec.HasValue ? questionnaireConfiguration.Quebec.Value : false,
                    Saskatchewan = questionnaireConfiguration.Saskatchewan.HasValue ? questionnaireConfiguration.Saskatchewan.Value : false,
                    YukonTerritory = questionnaireConfiguration.YukonTerritory.HasValue ? questionnaireConfiguration.YukonTerritory.Value : false,
                    NorthwestTerritories = questionnaireConfiguration.NorthwestTerritories.HasValue ? questionnaireConfiguration.NorthwestTerritories.Value : false,
                    CreatedDate = questionnaireConfiguration.CreatedDate,
                    CreatedBy = questionnaireConfiguration.CreatedBy,
                    ModifiedDate = questionnaireConfiguration.ModifiedDate,
                    ModifiedBy = questionnaireConfiguration.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetQuestionnaireConfigurationItem failed:" + ex.Message);

                var vm = new QuestionnaireConfigurationItemViewModel();

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

        public async Task<int> GetQCDuplicateCount(string entityname, string entityfield)
        {

            Log.Information("GetQCDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new QuestionnaireConfigurationFilterSpecification(entityname, entityfield);

                var totalItems = await _questionnairesConfigurationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetQCDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetQCDuplicateCount(string entityname, string entityfield, int id)
        {

            Log.Information("GeQCtDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new QuestionnaireConfigurationFilterSpecification(entityname, entityfield, id);

                var totalItems = await _questionnairesConfigurationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GeQCtDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }
    }
}
