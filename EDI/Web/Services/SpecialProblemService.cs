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
    public class SpecialProblemService : ISpecialProblemService
    {
        private readonly ILogger<SpecialProblemService> _logger;
        private readonly IAsyncRepository<SpecialProblem> _specialProblemRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

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
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<SpecialProblemService>();
            _httpContextAccessor = httpContextAccessor;
            _specialProblemRepository = specialProblemRepository;
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

        public async Task DeleteSpecialProblemAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteSpecialProblemAsync started by:" + _username);

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
            await LogUsername();
            Log.Information("UpdateSpecialProblemAsync started by:" + _username);

            try
            {
                var _specialProblem = await _specialProblemRepository.GetByIdAsync(specialProblem.Id);

                Guard.Against.NullSpecialProblem(specialProblem.Id, _specialProblem);

                _specialProblem.SpecialProblemCode = specialProblem.SpecialProblemCode;
                _specialProblem.SpecialProblemEnglish = specialProblem.SpecialProblemEnglish;
                _specialProblem.SpecialProblemFrench = specialProblem.SpecialProblemFrench;
                _specialProblem.Sequence = specialProblem.Sequence;
                _specialProblem.ModifiedDate = DateTime.Now;
                _specialProblem.ModifiedBy = _username;

                await _specialProblemRepository.UpdateAsync(_specialProblem);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateSpecialProblemAsync failed:" + ex.Message);
            }
        }

        public async Task CreateSpecialProblemAsync(SpecialProblemItemViewModel specialProblem)
        {
            await LogUsername();
            Log.Information("CreateSpecialProblemAsync started by:" + _username);

            try
            {
                var _specialProblem = new SpecialProblem();

                _specialProblem.SpecialProblemCode = specialProblem.SpecialProblemCode;
                _specialProblem.SpecialProblemEnglish = specialProblem.SpecialProblemEnglish;
                _specialProblem.SpecialProblemFrench = specialProblem.SpecialProblemFrench;
                _specialProblem.Sequence = specialProblem.Sequence;
                _specialProblem.CreatedDate = DateTime.Now;
                _specialProblem.CreatedBy = _username;
                _specialProblem.ModifiedDate = DateTime.Now;
                _specialProblem.ModifiedBy = _username;

                await _specialProblemRepository.AddAsync(_specialProblem);
            }
            catch (Exception ex)
            {
                Log.Error("CreateSpecialProblemAsync failed:" + ex.Message);
            }
        }

        public async Task<SpecialProblemItemViewModel> GetSpecialProblemItem(int specialProblemId)
        {
            await LogUsername();
            Log.Information("GetSpecialProblemItem started by:" + _username);

            try
            {
                var specialProblem = await _specialProblemRepository.GetByIdAsync(specialProblemId);

                Guard.Against.NullSpecialProblem(specialProblemId, specialProblem);

                var vm = new SpecialProblemItemViewModel()
                {
                    Id = specialProblem.Id,
                    SpecialProblemCode = specialProblem.SpecialProblemCode,
                    SpecialProblemEnglish = specialProblem.SpecialProblemEnglish,
                    SpecialProblemFrench = specialProblem.SpecialProblemFrench,
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

        public async Task<int> GetDuplicateCount(string specialProblemcode)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new SpecialProblemFilterSpecification(specialProblemcode);

                var totalItems = await _specialProblemRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string specialProblemcode, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new SpecialProblemFilterSpecification(specialProblemcode, id);

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
