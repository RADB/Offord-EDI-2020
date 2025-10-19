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
        private readonly ISharedService _sharedService;

        public QuestionnaireService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Questionnaire> questionnaireRepository,
            IAsyncRepository<QuestionnairesConfiguration> questionnairesConfigurationRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
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
            _sharedService = sharedService;
        }

        public async Task DeleteQuestionnaireAsync(int Id)
        {

            _sharedService.WriteLogs("DeleteQuestionnaireAsync started by:" + _userSettings.UserName, true);

            try
            {
                var questionnaire = await _questionnaireRepository.GetByIdAsync(Id);

                Guard.Against.NullQuestionnaire(Id, questionnaire);

                await _questionnaireRepository.DeleteAsync(questionnaire);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteQuestionnaireAsync failed:" + ex.Message, false);
            }
        }

        public async Task DeleteQuestionnaireConfiguarionAsync(int Id)
        {

            _sharedService.WriteLogs("DeleteQuestionnaireConfiguarionAsync started by:" + _userSettings.UserName, true);

            try
            {
                var qc = await _questionnairesConfigurationRepository.GetByIdAsync(Id);

                Guard.Against.NullQuestionnaireConfiguration(Id, qc);

                await _questionnairesConfigurationRepository.DeleteAsync(qc);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteQuestionnaireConfiguarionAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateQuestionnaireAsync(QuestionnaireItemViewModel questionnaire)
        {

            _sharedService.WriteLogs("UpdateQuestionnaireAsync started by:" + _userSettings.UserName, true);

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
                _questionnaire.Alberta = questionnaire.Alberta;
                _questionnaire.BritishColumbia = questionnaire.BritishColumbia;
                _questionnaire.Manitoba = questionnaire.Manitoba;
                _questionnaire.NewBrunswick = questionnaire.NewBrunswick;
                _questionnaire.NewfoundlandandLabrador = questionnaire.NewfoundlandandLabrador;
                _questionnaire.NovaScotia = questionnaire.NovaScotia;
                _questionnaire.Nunavut = questionnaire.Nunavut;
                _questionnaire.Ontario = questionnaire.Ontario;
                _questionnaire.PrinceEdwardIsland = questionnaire.PrinceEdwardIsland;
                _questionnaire.Quebec = questionnaire.Quebec;
                _questionnaire.Saskatchewan = questionnaire.Saskatchewan;
                _questionnaire.YukonTerritory = questionnaire.YukonTerritory;
                _questionnaire.NorthwestTerritories = questionnaire.NorthwestTerritories;
                _questionnaire.NewYork = questionnaire.NewYork;
                _questionnaire.FirstNations = questionnaire.FirstNations;
                _questionnaire.MCFN = questionnaire.MCFN;
                _questionnaire.ModifiedDate = DateTime.Now;
                _questionnaire.ModifiedBy = _userSettings.UserName;

                await _questionnaireRepository.UpdateAsync(_questionnaire);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateQuestionnaireAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateQuestionnaireConfigurationAsync(QuestionnaireConfigurationItemViewModel questionnaireConfiguration)
        {

            _sharedService.WriteLogs("UpdateQuestionnaireConfigurationAsync started by:" + _userSettings.UserName, true);

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
                _questionnaireConfiguration.HelpTextEnglish = questionnaireConfiguration.HelpTextEnglish;
                _questionnaireConfiguration.HelpTextFrench = questionnaireConfiguration.HelpTextFrench;
                _questionnaireConfiguration.GroupName = questionnaireConfiguration.GroupName;
                _questionnaireConfiguration.ShowGroupName = questionnaireConfiguration.ShowGroupName;
                _questionnaireConfiguration.Sequence = questionnaireConfiguration.Sequence;
                _questionnaireConfiguration.IsRequired = questionnaireConfiguration.IsRequired;
                _questionnaireConfiguration.IsCollapsible = questionnaireConfiguration.IsCollapsible;
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
                _questionnaireConfiguration.NewYork = questionnaireConfiguration.NewYork;
                _questionnaireConfiguration.FirstNations = questionnaireConfiguration.FirstNations;
                _questionnaireConfiguration.MCFN = questionnaireConfiguration.MCFN;
                _questionnaireConfiguration.ModifiedDate = DateTime.Now;
                _questionnaireConfiguration.ModifiedBy = _userSettings.UserName;

                await _questionnairesConfigurationRepository.UpdateAsync(_questionnaireConfiguration);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateQuestionnaireConfigurationAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateQuestionnaireAsync(QuestionnaireItemViewModel questionnaire)
        {

            _sharedService.WriteLogs("CreateQuestionnaireAsync started by:" + _userSettings.UserName, true);

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
                _questionnaire.Alberta = questionnaire.Alberta;
                _questionnaire.BritishColumbia = questionnaire.BritishColumbia;
                _questionnaire.Manitoba = questionnaire.Manitoba;
                _questionnaire.NewBrunswick = questionnaire.NewBrunswick;
                _questionnaire.NewfoundlandandLabrador = questionnaire.NewfoundlandandLabrador;
                _questionnaire.NovaScotia = questionnaire.NovaScotia;
                _questionnaire.Nunavut = questionnaire.Nunavut;
                _questionnaire.Ontario = questionnaire.Ontario;
                _questionnaire.PrinceEdwardIsland = questionnaire.PrinceEdwardIsland;
                _questionnaire.Quebec = questionnaire.Quebec;
                _questionnaire.Saskatchewan = questionnaire.Saskatchewan;
                _questionnaire.YukonTerritory = questionnaire.YukonTerritory;
                _questionnaire.NorthwestTerritories = questionnaire.NorthwestTerritories;
                _questionnaire.NewYork = questionnaire.NewYork;
                _questionnaire.FirstNations = questionnaire.FirstNations;
                _questionnaire.MCFN = questionnaire.MCFN;
                _questionnaire.CreatedDate = DateTime.Now;
                _questionnaire.CreatedBy = _userSettings.UserName;
                _questionnaire.ModifiedDate = DateTime.Now;
                _questionnaire.ModifiedBy = _userSettings.UserName;

                await _questionnaireRepository.AddAsync(_questionnaire);
                return _questionnaire.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateQuestionnaireAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<int> CreateQuestionnaireConfigurationAsync(QuestionnaireConfigurationItemViewModel questionnaireConfiguration)
        {

            _sharedService.WriteLogs("CreateQuestionnaireConfigurationAsync started by:" + _userSettings.UserName, true);

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
                _questionnaireConfiguration.HelpTextEnglish = questionnaireConfiguration.HelpTextEnglish;
                _questionnaireConfiguration.HelpTextFrench = questionnaireConfiguration.HelpTextFrench;
                _questionnaireConfiguration.GroupName = questionnaireConfiguration.GroupName;
                _questionnaireConfiguration.ShowGroupName = questionnaireConfiguration.ShowGroupName;
                _questionnaireConfiguration.Sequence = questionnaireConfiguration.Sequence;
                _questionnaireConfiguration.IsRequired = questionnaireConfiguration.IsRequired;
                _questionnaireConfiguration.IsConditional = questionnaireConfiguration.IsConditional;
                _questionnaireConfiguration.Condition = questionnaireConfiguration.Condition;
                _questionnaireConfiguration.IsReadOnly = questionnaireConfiguration.IsReadOnly;
                _questionnaireConfiguration.IsCollapsible = questionnaireConfiguration.IsCollapsible;
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
                _questionnaireConfiguration.NewYork = questionnaireConfiguration.NewYork;
                _questionnaireConfiguration.FirstNations = questionnaireConfiguration.FirstNations;
                _questionnaireConfiguration.MCFN = questionnaireConfiguration.MCFN;
                _questionnaireConfiguration.ModifiedDate = DateTime.Now;
                _questionnaireConfiguration.ModifiedBy = _userSettings.UserName;
                _questionnaireConfiguration.CreatedDate = DateTime.Now;
                _questionnaireConfiguration.CreatedBy = _userSettings.UserName;

                await _questionnairesConfigurationRepository.AddAsync(_questionnaireConfiguration);
                return _questionnaireConfiguration.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateQuestionnaireConfigurationAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<QuestionnaireItemViewModel> GetQuestionnaireItem(int questionnaireId)
        {

            _sharedService.WriteLogs("GetQuestionnaireItem started by:" + _userSettings.UserName, true);

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
                    Alberta = questionnaire.Alberta.HasValue ? questionnaire.Alberta.Value : false,
                    BritishColumbia = questionnaire.BritishColumbia.HasValue ? questionnaire.BritishColumbia.Value : false,
                    Manitoba = questionnaire.Manitoba.HasValue ? questionnaire.Manitoba.Value : false,
                    NewBrunswick = questionnaire.NewBrunswick.HasValue ? questionnaire.NewBrunswick.Value : false,
                    NewfoundlandandLabrador = questionnaire.NewfoundlandandLabrador.HasValue ? questionnaire.NewfoundlandandLabrador.Value : false,
                    NovaScotia = questionnaire.NovaScotia.HasValue ? questionnaire.NovaScotia.Value : false,
                    Nunavut = questionnaire.Nunavut.HasValue ? questionnaire.Nunavut.Value : false,
                    Ontario = questionnaire.Ontario.HasValue ? questionnaire.Ontario.Value : false,
                    PrinceEdwardIsland = questionnaire.PrinceEdwardIsland.HasValue ? questionnaire.PrinceEdwardIsland.Value : false,
                    Quebec = questionnaire.Quebec.HasValue ? questionnaire.Quebec.Value : false,
                    Saskatchewan = questionnaire.Saskatchewan.HasValue ? questionnaire.Saskatchewan.Value : false,
                    YukonTerritory = questionnaire.YukonTerritory.HasValue ? questionnaire.YukonTerritory.Value : false,
                    NorthwestTerritories = questionnaire.NorthwestTerritories.HasValue ? questionnaire.NorthwestTerritories.Value : false,
                    NewYork = questionnaire.NewYork.HasValue ? questionnaire.NewYork.Value : false,
                    FirstNations = questionnaire.FirstNations.HasValue ? questionnaire.FirstNations.Value : false,
                    MCFN = questionnaire.MCFN.HasValue ? questionnaire.MCFN.Value : false,
                    CreatedDate = questionnaire.CreatedDate,
                    CreatedBy = questionnaire.CreatedBy,
                    ModifiedDate = questionnaire.ModifiedDate,
                    ModifiedBy = questionnaire.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetQuestionnaireItem failed:" + ex.Message, false);

                var vm = new QuestionnaireItemViewModel();

                return vm;
            }
        }

        public async Task<QuestionnaireConfigurationItemViewModel> GetQuestionnaireConfigurationItem(int questionnaireConfigurationId)
        {

            _sharedService.WriteLogs("GetQuestionnaireConfigurationItem started by:" + _userSettings.UserName, true);

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
                    HelpTextEnglish = questionnaireConfiguration.HelpTextEnglish,
                    HelpTextFrench = questionnaireConfiguration.HelpTextFrench,
                    GroupName = questionnaireConfiguration.GroupName,
                    ShowGroupName = questionnaireConfiguration.ShowGroupName,
                    Sequence = questionnaireConfiguration.Sequence,
                    IsRequired = questionnaireConfiguration.IsRequired,
                    IsConditional = questionnaireConfiguration.IsConditional,
                    Condition = questionnaireConfiguration.Condition,
                    IsReadOnly = questionnaireConfiguration.IsReadOnly,
                    IsCollapsible = questionnaireConfiguration.IsCollapsible,
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
                    NewYork = questionnaireConfiguration.NewYork.HasValue ? questionnaireConfiguration.NewYork.Value : false,
                    FirstNations = questionnaireConfiguration.FirstNations.HasValue ? questionnaireConfiguration.FirstNations.Value : false,
                    MCFN = questionnaireConfiguration.MCFN.HasValue ? questionnaireConfiguration.MCFN.Value : false,
                    CreatedDate = questionnaireConfiguration.CreatedDate,
                    CreatedBy = questionnaireConfiguration.CreatedBy,
                    ModifiedDate = questionnaireConfiguration.ModifiedDate,
                    ModifiedBy = questionnaireConfiguration.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetQuestionnaireConfigurationItem failed:" + ex.Message, false);

                var vm = new QuestionnaireConfigurationItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string name)
        {

            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new QuestionnaireFilterSpecification(name);

                var totalItems = await _questionnaireRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string name, int id)
        {

            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new QuestionnaireFilterSpecification(name, id);

                var totalItems = await _questionnaireRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetQCDuplicateCount(string entityname, string entityfield)
        {

            _sharedService.WriteLogs("GetQCDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new QuestionnaireConfigurationFilterSpecification(entityname, entityfield);

                var totalItems = await _questionnairesConfigurationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetQCDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetQCDuplicateCount(string entityname, string entityfield, int id)
        {

            _sharedService.WriteLogs("GeQCtDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new QuestionnaireConfigurationFilterSpecification(entityname, entityfield, id);

                var totalItems = await _questionnairesConfigurationRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GeQCtDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }
    }
}
