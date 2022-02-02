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

namespace EDI.Web.Services
{
    public class SchoolService: ISchoolService
    {
        private readonly ILogger<SchoolService> _logger;
        private readonly IAsyncRepository<School> _schoolRepository;
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

        public SchoolService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<School> schoolRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<SchoolService>();
            _httpContextAccessor = httpContextAccessor;
            _schoolRepository = schoolRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
            _sharedService = sharedService;
        }

        public async Task DeleteSchoolAsync(int Id)
        {
            
            _sharedService.WriteLogs("DeleteSchoolAsync started by:" + _userSettings.UserName, true);

            try
            {
                var school = await _schoolRepository.GetByIdAsync(Id);

                Guard.Against.NullSchool(Id, school);

                await _schoolRepository.DeleteAsync(school);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteSchoolAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateSchoolAsync(SchoolItemViewModel school)
        {
            
            _sharedService.WriteLogs("UpdateSchoolAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _school = await _schoolRepository.GetByIdAsync(school.Id);

                Guard.Against.NullSchool(school.Id, _school);

                _school.SchoolNumber = school.SchoolNumber;
                _school.SchoolName = school.SchoolName;
                _school.Description = school.Description;
                _school.CountryId = school.CountryId;
                _school.ProvinceId = school.ProvinceId;
                _school.SiteId = school.SiteId;
                _school.YearId = school.YearId;
                _school.City = school.City;
               // _school.Elpschool = school.Elpschool;
                _school.ModifiedDate = DateTime.Now;
                _school.ModifiedBy = _userSettings.UserName;

                await _schoolRepository.UpdateAsync(_school);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateSchoolAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateSchoolAsync(SchoolItemViewModel school)
        {
            
            _sharedService.WriteLogs("CreateSchoolAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _school = new School();

                _school.SchoolNumber = school.SchoolNumber;
                _school.SchoolName = school.SchoolName;
                _school.Description = school.Description;
                _school.CountryId = school.CountryId;
                _school.ProvinceId = school.ProvinceId;
                _school.SiteId = school.SiteId;
                _school.YearId = school.YearId;
                _school.City = school.City;
               // _school.Elpschool = school.Elpschool;
                _school.CreatedDate = DateTime.Now;
                _school.CreatedBy = _userSettings.UserName;
                _school.ModifiedDate = DateTime.Now;
                _school.ModifiedBy = _userSettings.UserName;

                await _schoolRepository.AddAsync(_school);
                return _school.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateSchoolAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<SchoolItemViewModel> GetSchoolItem(int schoolId)
        {
            
            _sharedService.WriteLogs("GetSchoolItem started by:" + _userSettings.UserName, true);

            try
            {
                var school = await _schoolRepository.GetByIdAsync(schoolId);

                Guard.Against.NullSchool(schoolId, school);

                var vm = new SchoolItemViewModel()
                {
                    Id = school.Id,
                    SchoolNumber = school.SchoolNumber,
                    SchoolName = school.SchoolName,
                    Description = school.Description,                    
                    CountryId = school.CountryId,
                    ProvinceId = school.ProvinceId,
                    SiteId = school.SiteId,
                    YearId = school.YearId,
                    City = school.City,                    
                    CreatedDate = school.CreatedDate,
                    CreatedBy = school.CreatedBy,
                    ModifiedDate = school.ModifiedDate,
                    ModifiedBy = school.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetSchoolItem failed:" + ex.Message, false);

                var vm = new SchoolItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int siteid, string schoolnumber, int yearid)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new SchoolFilterSpecification(siteid, yearid, schoolnumber);

                var totalItems = await _schoolRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int siteid, string schoolnumber, int id, int yearid)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new SchoolFilterSpecification(siteid, yearid, schoolnumber, id);

                var totalItems = await _schoolRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }
    }
}
