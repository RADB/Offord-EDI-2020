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
            UserSettings UserSettings,
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
            EDIppSettings = settings.Value;
        }

        public async Task DeleteChildAsync(int Id)
        {
            
            Log.Information("DeleteChildAsync started by:" + _userSettings.UserName);

            try
            {
                var child = await _childRepository.GetByIdAsync(Id);

                Guard.Against.NullChild(Id, child);

                await _childRepository.DeleteAsync(child);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteChildAsync failed:" + ex.Message);
            }
        }

        public async Task UnlockChildAsync(int id)
        {
            Log.Information("UnlockChildAsync started by:" + _userSettings.UserName);

            try
            {
                var _child = await _childRepository.GetByIdAsync(id);

                Guard.Against.NullChild(id, _child);

                var childstatus = _dbContext.ChildStatuses.Where(p => p.English == "In Progress").FirstOrDefault();

                _child.ChildStatusId = childstatus.Id;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _userSettings.UserName;

                await _childRepository.UpdateAsync(_child);
            }
            catch (Exception ex)
            {
                Log.Error("UnlockChildAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateChildAsync(ChildItemViewModel child)
        {
            
            Log.Information("UpdateChildAsync started by:" + _userSettings.UserName);

            try
            {
                var _child = await _childRepository.GetByIdAsync(child.Id);

                Guard.Against.NullChild(child.Id, _child);

                _child.Ediid = child.Ediid;
                _child.LocalId = child.LocalId;
                _child.ChildNumber = child.ChildNumber;
                _child.YearId = child.YearId;
                _child.TeacherId = child.TeacherId;
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
                Log.Error("UpdateChildAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateChildAsync(ChildItemViewModel child)
        {
            
            Log.Information("CreateChildAsync started by:" + _userSettings.UserName);

            try
            {
                var _child = new Child();

                _child.Ediid = child.Ediid;
                _child.LocalId = child.LocalId;
                _child.ChildNumber = child.ChildNumber;
                _child.YearId = child.YearId;
                _child.TeacherId = child.TeacherId;
                _child.GenderId = child.GenderId;
                _child.Dob = child.Dob;
                _child.PostalCode = child.PostalCode;
                _child.ChildStatusId = child.ChildStatusId;
                _child.CreatedDate = DateTime.Now;
                _child.CreatedBy = _userSettings.UserName;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _userSettings.UserName;

                await _childRepository.AddAsync(_child);

                if (_child.Id > 0)
                {
                    var childid = _child.Id;
                    var _demographics = new QuestionnairesDataDemographic();

                    _demographics.ChildId = childid;
                    _demographics.CreatedDate = DateTime.Now;
                    _demographics.CreatedBy = _userSettings.UserName;
                    _demographics.ModifiedDate = DateTime.Now;
                    _demographics.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataDemographic.AddAsync(_demographics);

                    var _sectionA = new QuestionnairesDataSectionA();

                    _sectionA.ChildId = childid;
                    _sectionA.CreatedDate = DateTime.Now;
                    _sectionA.CreatedBy = _userSettings.UserName;
                    _sectionA.ModifiedDate = DateTime.Now;
                    _sectionA.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionA.AddAsync(_sectionA);

                    var _sectionB = new QuestionnairesDataSectionB();

                    _sectionB.ChildId = childid;
                    _sectionB.CreatedDate = DateTime.Now;
                    _sectionB.CreatedBy = _userSettings.UserName;
                    _sectionB.ModifiedDate = DateTime.Now;
                    _sectionB.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionB.AddAsync(_sectionB);

                    var _sectionC = new QuestionnairesDataSectionC();

                    _sectionC.ChildId = childid;
                    _sectionC.CreatedDate = DateTime.Now;
                    _sectionC.CreatedBy = _userSettings.UserName;
                    _sectionC.ModifiedDate = DateTime.Now;
                    _sectionC.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionC.AddAsync(_sectionC);

                    var _sectionD = new QuestionnairesDataSectionD();

                    _sectionD.ChildId = childid;
                    _sectionD.CreatedDate = DateTime.Now;
                    _sectionD.CreatedBy = _userSettings.UserName;
                    _sectionD.ModifiedDate = DateTime.Now;
                    _sectionD.ModifiedBy = _userSettings.UserName;

                    await _questionnairesDataSectionD.AddAsync(_sectionD);

                    var _sectionE = new QuestionnairesDataSectionE();

                    _sectionE.ChildId = childid;
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
                Log.Error("CreateChildAsync failed:" + ex.Message);
                return 0;
            }
        }

        public async Task<ChildItemViewModel> GetChildItem(int childId)
        {
            
            Log.Information("GetChildItem started by:" + _userSettings.UserName);

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
                Log.Error("GetChildItem failed:" + ex.Message);

                var vm = new ChildItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string ediid)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new ChildFilterSpecification(ediid);

                var totalItems = await _childRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string ediid, int id)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new ChildFilterSpecification(ediid, id);

                var totalItems = await _childRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public int GetCompletedQuestions(int id)
        {

            Log.Information("GetCompletedQuestions started by:" + _userSettings.UserName);

            try
            {
                var demog = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiona = _dbContext.QuestionnairesDataSectionAs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionb = _dbContext.QuestionnairesDataSectionBs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionc = _dbContext.QuestionnairesDataSectionCs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiond = _dbContext.QuestionnairesDataSectionDs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectione = _dbContext.QuestionnairesDataSectionEs.Where(p => p.ChildId == id).FirstOrDefault();

                var totalItems = (demog.CompletedQuestions == 0 ? GetRandomNumber(1,10) : demog.CompletedQuestions) +
                                    (sectiona.CompletedQuestions == 0 ? GetRandomNumber(1, 10) : sectiona.CompletedQuestions) +
                                    (sectionb.CompletedQuestions == 0 ? GetRandomNumber(1, 10) : sectionb.CompletedQuestions) +
                                    (sectionc.CompletedQuestions == 0 ? GetRandomNumber(1, 10) : sectionc.CompletedQuestions) +
                                    (sectiond.CompletedQuestions == 0 ? GetRandomNumber(1, 10) : sectiond.CompletedQuestions) +
                                    (sectione.CompletedQuestions == 0 ? GetRandomNumber(1, 10) : sectione.CompletedQuestions);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetCompletedQuestions failed:" + ex.Message);
                return -1;
            }
        }

        public int GetRequiredQuestions(int id)
        {

            Log.Information("GetRequiredQuestions started by:" + _userSettings.UserName);

            try
            {
                var demog = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiona = _dbContext.QuestionnairesDataSectionAs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionb = _dbContext.QuestionnairesDataSectionBs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectionc = _dbContext.QuestionnairesDataSectionCs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectiond = _dbContext.QuestionnairesDataSectionDs.Where(p => p.ChildId == id).FirstOrDefault();
                var sectione = _dbContext.QuestionnairesDataSectionEs.Where(p => p.ChildId == id).FirstOrDefault();

                var totalItems = (demog.RequiredQuestions == 0 ? 10 : demog.RequiredQuestions) +
                                    (sectiona.RequiredQuestions == 0 ? 10 : sectiona.RequiredQuestions) +
                                    (sectionb.RequiredQuestions == 0 ? 10 : sectionb.RequiredQuestions) +
                                    (sectionc.RequiredQuestions == 0 ? 10 : sectionc.RequiredQuestions) +
                                    (sectiond.RequiredQuestions == 0 ? 10 : sectiond.RequiredQuestions) +
                                    (sectione.RequiredQuestions == 0 ? 10 : sectione.RequiredQuestions);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetRequiredQuestions failed:" + ex.Message);
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
                Log.Error("GetRandomNumber failed:" + ex.Message);

                return -1;
            }
        }
    }
}
