using EDI.ApplicationCore.Entities;
using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Specifications;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
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
using EDI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace EDI.Web.Services
{
    public class ChildService : IChildService
    {
        private readonly ILogger<ChildService> _logger;
        private readonly IAsyncRepository<Child> _childRepository;
        private readonly IAsyncRepository<QuestionnairesDataDemographic> _questionnairesDataDemographic;
        private readonly IAsyncRepository<QuestionnairesDataSectionA> _questionnairesDataSectionA;
        private readonly IAsyncRepository<QuestionnairesDataSectionB> _questionnairesDataSectionB;
        private readonly IAsyncRepository<QuestionnairesDataSectionC> _questionnairesDataSectionC;
        private readonly IAsyncRepository<QuestionnairesDataSectionD> _questionnairesDataSectionD;
        private readonly IAsyncRepository<QuestionnairesDataSectionE> _questionnairesDataSectionE;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }
        private readonly ServiceContext _dbContext;
        
        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;
        private readonly ISharedService _sharedService;
        private readonly MathService _mathService;

        public ChildService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Child> childRepository,
            IAsyncRepository<QuestionnairesDataDemographic> questionnairesDataDemographic,
            IAsyncRepository<QuestionnairesDataSectionA> questionnairesDataSectionA,
            IAsyncRepository<QuestionnairesDataSectionB> questionnairesDataSectionB,
            IAsyncRepository<QuestionnairesDataSectionC> questionnairesDataSectionC,
            IAsyncRepository<QuestionnairesDataSectionD> questionnairesDataSectionD,
            IAsyncRepository<QuestionnairesDataSectionE> questionnairesDataSectionE,
            IAsyncIdentityRepository accountRepository,
            ServiceContext dbContext,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IMathService mathService,
        IOptions<EDIAppSettings> settings)
        { 
            _logger = loggerFactory.CreateLogger<ChildService>();
            _httpContextAccessor = httpContextAccessor;
            _childRepository = childRepository;
            _questionnairesDataDemographic = questionnairesDataDemographic;
            _questionnairesDataSectionA = questionnairesDataSectionA;
            _questionnairesDataSectionB = questionnairesDataSectionB;
            _questionnairesDataSectionC = questionnairesDataSectionC;
            _questionnairesDataSectionD = questionnairesDataSectionD;
            _questionnairesDataSectionE = questionnairesDataSectionE;
            _accountRepository = accountRepository;
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            _mathService = (MathService)mathService;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteChildAsync(int Id)
        {
            
            _sharedService.WriteLogs("DeleteChildAsync started by:" + _userSettings.UserName, true);

            try
            {
                var child = await _childRepository.GetByIdAsync(Id);

                Guard.Against.NullChild(Id, child);

                await _childRepository.DeleteAsync(child);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteChildAsync failed:" + ex.Message, false);
            }
        }

        public async Task UnlockChildAsync(int id)
        {
            _sharedService.WriteLogs("UnlockChildAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _child = await _childRepository.GetByIdAsync(id);

                Guard.Against.NullChild(id, _child);

                var demo = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == _child.Id).FirstOrDefault();
                var seca = _dbContext.QuestionnairesDataSectionAs.Where(p => p.ChildId == _child.Id).FirstOrDefault();
                var secb = _dbContext.QuestionnairesDataSectionBs.Where(p => p.ChildId == _child.Id).FirstOrDefault();
                var secc = _dbContext.QuestionnairesDataSectionCs.Where(p => p.ChildId == _child.Id).FirstOrDefault();
                var secd = _dbContext.QuestionnairesDataSectionDs.Where(p => p.ChildId == _child.Id).FirstOrDefault();
                var sece = _dbContext.QuestionnairesDataSectionEs.Where(p => p.ChildId == _child.Id).FirstOrDefault();

                var childstatus = _dbContext.ChildStatuses.Where(p => p.English == "In Progress").FirstOrDefault();

                if(demo.IsComplete && seca.IsComplete && secb.IsComplete && secc.IsComplete && secd.IsComplete && sece.IsComplete)
                {
                    childstatus = _dbContext.ChildStatuses.Where(p => p.English == "Complete").FirstOrDefault();
                }

                _child.ChildStatusId = childstatus.Id;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _userSettings.UserName;

                await _childRepository.UpdateAsync(_child);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UnlockChildAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateChildAsync(ChildItemViewModel child)
        {
            
            _sharedService.WriteLogs("UpdateChildAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _child = await _childRepository.GetByIdAsync(child.Id);

                Guard.Against.NullChild(child.Id, _child);

                _child.Ediid = child.Ediid;
                _child.LocalId = child.LocalId;
                _child.ChildNumber = child.ChildNumber;
                _child.YearId = child.YearId;
                _child.TeacherId = child.TeacherId.Value;
                _child.GenderId = child.GenderId;
                _child.Dob = child.Dob;
                _child.PostalCode = child.PostalCode;
                _child.ChildStatusId = child.ChildStatusId;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _userSettings.UserName;

                await _childRepository.UpdateAsync(_child);

                var childdemog = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == child.Id).FirstOrDefault();

                childdemog.Dob = child.Dob;
                childdemog.PostalCode = child.PostalCode;
                childdemog.GenderId = child.GenderId;

                await _questionnairesDataDemographic.UpdateAsync(childdemog);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateChildAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateChildAsync(ChildItemViewModel child)
        {
            
            _sharedService.WriteLogs("CreateChildAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _child = new Child();

                _child.Ediid = child.Ediid;
                _child.LocalId = child.LocalId;
                _child.ChildNumber = child.ChildNumber;
                _child.YearId = child.YearId;
                _child.TeacherId = child.TeacherId.Value;
                _child.GenderId = child.GenderId;
                _child.Dob = child.Dob;
                _child.PostalCode = child.PostalCode;
                _child.ChildStatusId = child.ChildStatusId;
                _child.CreatedDate = DateTime.Now;
                _child.CreatedBy = _userSettings.UserName;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _userSettings.UserName;

                await _childRepository.AddAsync(_child);

                var provinceid = 0;
                var provincename = string.Empty;

                var provinceedicodestring = child.Ediid.Substring(2, 2);
                var provinceedicode = int.Parse(provinceedicodestring);
                var countryid = _dbContext.Provinces.Where(p => p.EDICode == provinceedicode).FirstOrDefault().CountryID;
                provinceid = _dbContext.Provinces.Where(p => p.EDICode == provinceedicode).FirstOrDefault().Id;
                provincename = _dbContext.Provinces.Where(p => p.EDICode == provinceedicode).FirstOrDefault().English.Replace(" ", "");

                var predicate = "p => p." + provincename + " == true && p.YearId == " + child.YearId + " && p.QuestionnaireName == \"Demographics\"";

                var questionnaire = _dbContext.Questionnaires.Where(predicate).FirstOrDefault();

                var predicateA = "p => p." + provincename + " == true && p.YearId == " + child.YearId + " && p.QuestionnaireName == \"Section A\"";

                var questionnaireA = _dbContext.Questionnaires.Where(predicateA).FirstOrDefault();

                var predicateB = "p => p." + provincename + " == true && p.YearId == " + child.YearId + " && p.QuestionnaireName == \"Section B\"";

                var questionnaireB = _dbContext.Questionnaires.Where(predicateB).FirstOrDefault();

                var predicateC = "p => p." + provincename + " == true && p.YearId == " + child.YearId + " && p.QuestionnaireName == \"Section C\"";

                var questionnaireC = _dbContext.Questionnaires.Where(predicateC).FirstOrDefault();

                var predicateD = "p => p." + provincename + " == true && p.YearId == " + child.YearId + " && p.QuestionnaireName == \"Section D\"";

                var questionnaireD = _dbContext.Questionnaires.Where(predicateD).FirstOrDefault();

                var predicateE = "p => p." + provincename + " == true && p.YearId == " + child.YearId + " && p.QuestionnaireName == \"Section E\"";

                var questionnaireE = _dbContext.Questionnaires.Where(predicateE).FirstOrDefault();

                if (_child.Id > 0)
                {
                    var childid = _child.Id;
                    var _demographics = new QuestionnairesDataDemographic();

                    _demographics.ChildId = childid;
                    _demographics.GenderId = child.GenderId;
                    _demographics.Dob = child.Dob;
                    _demographics.PostalCode = child.PostalCode;
                    _demographics.YearId = child.YearId;
                    _demographics.QuestionnaireId = questionnaire.Id;
                    _demographics.CreatedDate = DateTime.Now;
                    _demographics.CreatedBy = _userSettings.UserName;
                    _demographics.ModifiedDate = DateTime.Now;
                    _demographics.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataDemographic.AddAsync(_demographics);

                    var _sectionA = new QuestionnairesDataSectionA();

                    _sectionA.ChildId = childid;
                    _sectionA.QuestionnaireId = questionnaireA.Id;
                    _sectionA.YearId = child.YearId;
                    _sectionA.CreatedDate = DateTime.Now;
                    _sectionA.CreatedBy = _userSettings.UserName;
                    _sectionA.ModifiedDate = DateTime.Now;
                    _sectionA.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionA.AddAsync(_sectionA);

                    var _sectionB = new QuestionnairesDataSectionB();

                    _sectionB.ChildId = childid;
                    _sectionB.QuestionnaireId = questionnaireB.Id;
                    _sectionB.YearId = child.YearId;
                    _sectionB.CreatedDate = DateTime.Now;
                    _sectionB.CreatedBy = _userSettings.UserName;
                    _sectionB.ModifiedDate = DateTime.Now;
                    _sectionB.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionB.AddAsync(_sectionB);

                    var _sectionC = new QuestionnairesDataSectionC();

                    _sectionC.ChildId = childid;
                    _sectionC.QuestionnaireId = questionnaireC.Id;
                    _sectionC.YearId = child.YearId;
                    _sectionC.CreatedDate = DateTime.Now;
                    _sectionC.CreatedBy = _userSettings.UserName;
                    _sectionC.ModifiedDate = DateTime.Now;
                    _sectionC.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionC.AddAsync(_sectionC);

                    var _sectionD = new QuestionnairesDataSectionD();

                    _sectionD.ChildId = childid;
                    _sectionD.QuestionnaireId = questionnaireD.Id;
                    _sectionD.YearId = child.YearId;
                    _sectionD.CreatedDate = DateTime.Now;
                    _sectionD.CreatedBy = _userSettings.UserName;
                    _sectionD.ModifiedDate = DateTime.Now;
                    _sectionD.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionD.AddAsync(_sectionD);

                    var _sectionE = new QuestionnairesDataSectionE();

                    _sectionE.ChildId = childid;
                    _sectionE.QuestionnaireId = questionnaireE.Id;
                    _sectionE.YearId = child.YearId;
                    _sectionE.CreatedDate = DateTime.Now;
                    _sectionE.CreatedDate = DateTime.Now;
                    _sectionE.CreatedBy = _userSettings.UserName;
                    _sectionE.ModifiedDate = DateTime.Now;
                    _sectionE.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionE.AddAsync(_sectionE);
                }
                return _child.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateChildAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<ChildItemViewModel> GetChildItem(int childId)
        {
            
            _sharedService.WriteLogs("GetChildItem started by:" + _userSettings.UserName, true);

            try
            {
                var child = await _childRepository.GetByIdAsync(childId);

                Guard.Against.NullChild(childId, child);

                var vm = new ChildItemViewModel()
                {
                    Id = child.Id,
                    Ediid = child.Ediid,
                    LocalId = child.LocalId,
                    ChildNumber = child.ChildNumber,
                    YearId = child.YearId,
                    TeacherId = child.TeacherId,
                    GenderId = child.GenderId,
                    ChildStatusId = child.ChildStatusId,
                    Dob = child.Dob,
                    PostalCode = child.PostalCode,
                    CreatedDate = child.CreatedDate,
                    CreatedBy = child.CreatedBy,
                    ModifiedDate = child.ModifiedDate,
                    ModifiedBy = child.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetChildItem failed:" + ex.Message, false);

                var vm = new ChildItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string ediid, int yearid)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new ChildFilterSpecification(ediid, yearid);

                var totalItems = await _childRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string ediid, int id, int yearid)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new ChildFilterSpecification(ediid, yearid, id);

                var totalItems = await _childRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public int GetCompletedQuestions(int id)
        {

            _sharedService.WriteLogs("GetCompletedQuestions started by:" + _userSettings.UserName, true);

            try
            {
                var demog = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiona = _dbContext.QuestionnairesDataSectionAs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionb = _dbContext.QuestionnairesDataSectionBs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionc = _dbContext.QuestionnairesDataSectionCs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiond = _dbContext.QuestionnairesDataSectionDs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectione = _dbContext.QuestionnairesDataSectionEs.Where(p => p.ChildId == id).FirstOrDefault();

                var totalItems = demog.CompletedQuestions + sectiona.CompletedQuestions + sectionb.CompletedQuestions +
                                    sectionc.CompletedQuestions + sectiond.CompletedQuestions + sectione.CompletedQuestions;

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetCompletedQuestions failed:" + ex.Message, false);
                return -1;
            }
        }

        public int GetRequiredQuestions(int id)
        {

            _sharedService.WriteLogs("GetRequiredQuestions started by:" + _userSettings.UserName, true);

            try
            {
                var demog = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiona = _dbContext.QuestionnairesDataSectionAs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionb = _dbContext.QuestionnairesDataSectionBs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionc = _dbContext.QuestionnairesDataSectionCs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiond = _dbContext.QuestionnairesDataSectionDs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectione = _dbContext.QuestionnairesDataSectionEs.Where(p => p.ChildId == id).FirstOrDefault();

                var totalItems = demog.RequiredQuestions + sectiona.RequiredQuestions + sectionb.RequiredQuestions +
                                    sectionc.RequiredQuestions + sectiond.RequiredQuestions + sectione.RequiredQuestions;

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetRequiredQuestions failed:" + ex.Message, false);
                return -1;
            }
        }
        public int GetPercentComplete(int id, int numberOfQuestionnaires)
        {

            _sharedService.WriteLogs("GetPercentComplete started by:" + _userSettings.UserName, true);

            try
            {
                // override this if you need to make this variable.
                //numberOfQuestionnaires = 6;                

                var child = _dbContext.Children.Where("Id ==" + id + " && YearId == " + _userSettings.YearId)
                        .Include(c => c.QuestionnairesDataDemographics)
                        .Include(c => c.QuestionnairesDataSectionAs)
                        .Include(c => c.QuestionnairesDataSectionBs)
                        .Include(c => c.QuestionnairesDataSectionCs)
                        .Include(c => c.QuestionnairesDataSectionDs)
                        .Include(c => c.QuestionnairesDataSectionEs)
                        .Single();
                var test = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == id && p.YearId == 1).FirstOrDefault();
                var demographicsComplete = _mathService.GetPercentComplete(child.QuestionnairesDataDemographics.Single().CompletedQuestions,child.QuestionnairesDataDemographics.Single().RequiredQuestions == 0 ? 1 : child.QuestionnairesDataDemographics.Single().RequiredQuestions, numberOfQuestionnaires);
                var sectionAComplete = _mathService.GetPercentComplete(child.QuestionnairesDataSectionAs.Single().CompletedQuestions, child.QuestionnairesDataSectionAs.Single().RequiredQuestions == 0 ? 1 : child.QuestionnairesDataSectionAs.Single().RequiredQuestions, numberOfQuestionnaires);
                var sectionBComplete = _mathService.GetPercentComplete(child.QuestionnairesDataSectionBs.Single().CompletedQuestions, child.QuestionnairesDataSectionBs.Single().RequiredQuestions == 0 ? 1 : child.QuestionnairesDataSectionBs.Single().RequiredQuestions, numberOfQuestionnaires);
                var sectionCComplete = _mathService.GetPercentComplete(child.QuestionnairesDataSectionCs.Single().CompletedQuestions, child.QuestionnairesDataSectionCs.Single().RequiredQuestions == 0 ? 1 : child.QuestionnairesDataSectionCs.Single().RequiredQuestions, numberOfQuestionnaires);
                var sectionDComplete = _mathService.GetPercentComplete(child.QuestionnairesDataSectionDs.Single().CompletedQuestions, child.QuestionnairesDataSectionDs.Single().RequiredQuestions == 0 ? 1 : child.QuestionnairesDataSectionDs.Single().RequiredQuestions, numberOfQuestionnaires);
                var sectionEComplete = _mathService.GetPercentComplete(child.QuestionnairesDataSectionEs.Single().CompletedQuestions, child.QuestionnairesDataSectionEs.Single().RequiredQuestions == 0 ? 1 : child.QuestionnairesDataSectionEs.Single().RequiredQuestions, numberOfQuestionnaires);

                var percentComplete = Math.Min(demographicsComplete + sectionAComplete + sectionBComplete + sectionCComplete + sectionDComplete + sectionEComplete, 100);

                return percentComplete;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetPercentComplete failed:" + ex.Message, false);
                return -1;
            }
        }

        private int GetRandomNumber(int minimum, int maximum)
        {
            try
            {
                Random rnd = new Random();
                int number = rnd.Next(minimum, maximum);

                return number;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetRandomNumber failed:" + ex.Message, false);

                return -1;
            }
        }

    }
}
