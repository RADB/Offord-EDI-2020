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
using EDI.Infrastructure.Data;
using System.Linq;

namespace EDI.Web.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ILogger<TeacherService> _logger;
        private readonly IAsyncRepository<Teacher> _teacherRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private readonly ServiceContext _dbContext;
        private readonly AppIdentityDbContext _identityContext;
        private readonly UserManager<ApplicationUser> _userManager;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public TeacherService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Teacher> teacherRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ServiceContext dbContext,
            AppIdentityDbContext identityContext,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<TeacherService>();
            _httpContextAccessor = httpContextAccessor;
            _teacherRepository = teacherRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _dbContext = dbContext;
            _identityContext = identityContext;
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

        public async Task DeleteTeacherAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteTeacherAsync started by:" + _username);

            try
            {
                var teacher = await _teacherRepository.GetByIdAsync(Id);

                Guard.Against.NullTeacher(Id, teacher);

                await _teacherRepository.DeleteAsync(teacher);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteTeacherAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateTeacherAsync(TeacherItemViewModel teacher)
        {
            await LogUsername();
            Log.Information("UpdateTeacherAsync started by:" + _username);

            try
            {
                var _teacher = await _teacherRepository.GetByIdAsync(teacher.Id);

                Guard.Against.NullTeacher(teacher.Id, _teacher);

                _teacher.TeacherNumber = teacher.TeacherNumber;
                _teacher.SchoolId = teacher.SchoolId;
                _teacher.YearId = teacher.YearId;
                _teacher.TeacherName = teacher.TeacherName;
                _teacher.Email = teacher.Email;
                _teacher.PhoneNumber = teacher.PhoneNumber;
                _teacher.ModifiedDate = DateTime.Now;
                _teacher.ModifiedBy = _username;

                await _teacherRepository.UpdateAsync(_teacher);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateTeacherAsync failed:" + ex.Message);
            }
        }

        public async Task CreateTeacherAsync(TeacherItemViewModel teacher)
        {
            await LogUsername();
            Log.Information("CreateTeacherAsync started by:" + _username);

            try
            {
                var _teacher = new Teacher();

                var user = _identityContext.Users.Where(p => p.UserName == teacher.Email).FirstOrDefault();
                string userid = string.Empty;

                if (user == null)
                {
                    try
                    {
                        string[] names = teacher.TeacherName.Split(' ');
                        string firstname = names[0];
                        string lastname = names[1];

                        var newuser = new ApplicationUser
                        {
                            UserName = teacher.Email,
                            Email = teacher.Email,
                            FirstName = firstname,
                            LastName = lastname
                        };
                        var result = await _userManager.CreateAsync(newuser);

                        var role = _identityContext.Roles.Where(p => p.Name == "Teacher").FirstOrDefault();

                        await _userManager.AddToRoleAsync(newuser, role.Name);

                        userid = newuser.Id;
                    }
                    catch (Exception ex)
                    {
                        Log.Error("CreateTeacherAsync failed:" + ex.Message);
                    }
                }
                else
                {
                    userid = user.Id;
                }

                _teacher.UserId = userid;
                _teacher.TeacherNumber = teacher.TeacherNumber;
                _teacher.SchoolId = teacher.SchoolId;
                _teacher.YearId = teacher.YearId;
                _teacher.TeacherName = teacher.TeacherName;
                _teacher.Email = teacher.Email;
                _teacher.PhoneNumber = teacher.PhoneNumber;
                _teacher.CreatedDate = DateTime.Now;
                _teacher.CreatedBy = _username;
                _teacher.ModifiedDate = DateTime.Now;
                _teacher.ModifiedBy = _username;

                await _teacherRepository.AddAsync(_teacher);
            }
            catch (Exception ex)
            {
                Log.Error("CreateTeacherAsync failed:" + ex.Message);
            }
        }

        public async Task<TeacherItemViewModel> GetTeacherItem(int teacherId)
        {
            await LogUsername();
            Log.Information("GetTeacherItem started by:" + _username);

            try
            {
                var teacher = await _teacherRepository.GetByIdAsync(teacherId);

                Guard.Against.NullTeacher(teacherId, teacher);

                var vm = new TeacherItemViewModel()
                {
                    Id = teacher.Id,
                    UserId = teacher.UserId,
                    TeacherNumber = teacher.TeacherNumber,
                    SchoolId = teacher.SchoolId,
                    SiteId = _dbContext.Schools.Where(s => s.Id == teacher.SchoolId).Select(s=>s.SiteId).FirstOrDefault(),
                    YearId = teacher.YearId,
                    TeacherName = teacher.TeacherName,
                    Email = teacher.Email,
                    PhoneNumber = teacher.PhoneNumber,
                    CreatedDate = teacher.CreatedDate,
                    CreatedBy = teacher.CreatedBy,
                    ModifiedDate = teacher.ModifiedDate,
                    ModifiedBy = teacher.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetTeacherItem failed:" + ex.Message);

                var vm = new TeacherItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(int schoolid, string teachernumber)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new TeacherFilterSpecification(schoolid, teachernumber);

                var totalItems = await _teacherRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(int schoolid, string teachernumber, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new TeacherFilterSpecification(schoolid, teachernumber, id);

                var totalItems = await _teacherRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string teachername, string email)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new TeacherFilterSpecification(teachername, email);

                var totalItems = await _teacherRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string teachername, string email, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new TeacherFilterSpecification(teachername, email, id);

                var totalItems = await _teacherRepository.CountAsync(filterSpecification);

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
