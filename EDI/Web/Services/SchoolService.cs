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

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public SchoolService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<School> schoolRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<SchoolService>();
            _httpContextAccessor = httpContextAccessor;
            _schoolRepository = schoolRepository;
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

        public async Task DeleteSchoolAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteSchoolAsync started by:" + _username);

            try
            {
                var school = await _schoolRepository.GetByIdAsync(Id);

                Guard.Against.NullSchool(Id, school);

                await _schoolRepository.DeleteAsync(school);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteSchoolAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateSchoolAsync(SchoolItemViewModel school)
        {
            await LogUsername();
            Log.Information("UpdateSchoolAsync started by:" + _username);

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
                _school.City = school.City;
                _school.Elpschool = school.Elpschool;
                _school.ModifiedDate = DateTime.Now;
                _school.ModifiedBy = _username;

                await _schoolRepository.UpdateAsync(_school);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateSchoolAsync failed:" + ex.Message);
            }
        }

        public async Task CreateSchoolAsync(SchoolItemViewModel school)
        {
            await LogUsername();
            Log.Information("CreateSchoolAsync started by:" + _username);

            try
            {
                var _school = new School();

                _school.SchoolNumber = school.SchoolNumber;
                _school.SchoolName = school.SchoolName;
                _school.Description = school.Description;
                _school.CountryId = school.CountryId;
                _school.ProvinceId = school.ProvinceId;
                _school.SiteId = school.SiteId;
                _school.City = school.City;
                _school.Elpschool = school.Elpschool;
                _school.CreatedDate = DateTime.Now;
                _school.CreatedBy = _username;
                _school.ModifiedDate = DateTime.Now;
                _school.ModifiedBy = _username;

                await _schoolRepository.AddAsync(_school);
            }
            catch (Exception ex)
            {
                Log.Error("CreateSchoolAsync failed:" + ex.Message);
            }
        }

        public async Task<SchoolItemViewModel> GetSchoolItem(int schoolId)
        {
            await LogUsername();
            Log.Information("GetSchoolItem started by:" + _username);

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
                    City = school.City,
                    Elpschool = school.Elpschool,
                    CreatedDate = school.CreatedDate,
                    CreatedBy = school.CreatedBy,
                    ModifiedDate = school.ModifiedDate,
                    ModifiedBy = school.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetSchoolItem failed:" + ex.Message);

                var vm = new SchoolItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string schoolnumber)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new SchoolFilterSpecification(schoolnumber);

                var totalItems = await _schoolRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string schoolnumber, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new SchoolFilterSpecification(schoolnumber, id);

                var totalItems = await _schoolRepository.CountAsync(filterSpecification);

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
