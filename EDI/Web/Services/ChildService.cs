﻿using EDI.ApplicationCore.Entities;
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
                _child.PostalCodeZip = child.PostalCodeZip;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _userSettings.UserName;

                await _childRepository.UpdateAsync(_child);
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
                _child.PostalCodeZip = child.PostalCodeZip;
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
                    Dob = child.Dob,
                    PostalCodeZip = child.PostalCodeZip,
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
    }
}
