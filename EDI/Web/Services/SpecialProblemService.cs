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
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using EDI.Infrastructure.Identity;

namespace EDI.Web.Services
{
    public class SpecialProblemService : ISpecialProblemService
    {
        private readonly ILogger<SpecialProblemService> _logger;
        private readonly IAsyncRepository<SpecialProblem> _specialProblemRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private UserSettings _userSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public SpecialProblemService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<SpecialProblem> specialProblemRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<SpecialProblemService>();
            _httpContextAccessor = httpContextAccessor;
            _specialProblemRepository = specialProblemRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteSpecialProblemAsync(int Id)
        {
            
            Log.Information("DeleteSpecialProblemAsync started by:" + _userSettings.UserName);

            try
            {
                var specialProblem = await _specialProblemRepository.GetByIdAsync(Id);

                Guard.Against.NullSpecialProblem(Id, specialProblem);

                await _specialProblemRepository.DeleteAsync(specialProblem);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteSpecialProblemAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateSpecialProblemAsync(SpecialProblemItemViewModel specialProblem)
        {
            
            Log.Information("UpdateSpecialProblemAsync started by:" + _userSettings.UserName);

            try
            {
                var _specialProblem = await _specialProblemRepository.GetByIdAsync(specialProblem.Id);

                Guard.Against.NullSpecialProblem(specialProblem.Id, _specialProblem);

                _specialProblem.Code = specialProblem.Code;
                _specialProblem.English = specialProblem.English;
                _specialProblem.French = specialProblem.French;
                _specialProblem.Sequence = specialProblem.Sequence;
                _specialProblem.ModifiedDate = DateTime.Now;
                _specialProblem.ModifiedBy = _userSettings.UserName;

                await _specialProblemRepository.UpdateAsync(_specialProblem);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateSpecialProblemAsync failed:" + ex.Message);
            }
        }

        public async Task CreateSpecialProblemAsync(SpecialProblemItemViewModel specialProblem)
        {
            
            Log.Information("CreateSpecialProblemAsync started by:" + _userSettings.UserName);

            try
            {
                var _specialProblem = new SpecialProblem();

                _specialProblem.Code = specialProblem.Code;
                _specialProblem.English = specialProblem.English;
                _specialProblem.French = specialProblem.French;
                _specialProblem.Sequence = specialProblem.Sequence;
                _specialProblem.CreatedDate = DateTime.Now;
                _specialProblem.CreatedBy = _userSettings.UserName;
                _specialProblem.ModifiedDate = DateTime.Now;
                _specialProblem.ModifiedBy = _userSettings.UserName;

                await _specialProblemRepository.AddAsync(_specialProblem);
            }
            catch (Exception ex)
            {
                Log.Error("CreateSpecialProblemAsync failed:" + ex.Message);
            }
        }

        public async Task<SpecialProblemItemViewModel> GetSpecialProblemItem(int specialProblemId)
        {
            
            Log.Information("GetSpecialProblemItem started by:" + _userSettings.UserName);

            try
            {
                var specialProblem = await _specialProblemRepository.GetByIdAsync(specialProblemId);

                Guard.Against.NullSpecialProblem(specialProblemId, specialProblem);

                var vm = new SpecialProblemItemViewModel()
                {
                    Id = specialProblem.Id,
                    Code = specialProblem.Code,
                    English = specialProblem.English,
                    French = specialProblem.French,
                    Sequence = specialProblem.Sequence,
                    CreatedDate = specialProblem.CreatedDate,
                    CreatedBy = specialProblem.CreatedBy,
                    ModifiedDate = specialProblem.ModifiedDate,
                    ModifiedBy = specialProblem.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetSpecialProblemItem failed:" + ex.Message);

                var vm = new SpecialProblemItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string Code)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new SpecialProblemFilterSpecification(Code);

                var totalItems = await _specialProblemRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string Code, int id)
        {
            
            Log.Information("GetDuplicateCount started by:" + _userSettings.UserName);

            try
            {
                var filterSpecification = new SpecialProblemFilterSpecification(Code, id);

                var totalItems = await _specialProblemRepository.CountAsync(filterSpecification);

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
