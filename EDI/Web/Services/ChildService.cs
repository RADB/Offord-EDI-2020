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
    public class ChildService : IChildService
    {
        private readonly ILogger<ChildService> _logger;
        private readonly IAsyncRepository<Child> _childRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public ChildService(
            UserManager<ApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Child> childRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<ChildService>();
            _httpContextAccessor = httpContextAccessor;
            _childRepository = childRepository;
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

        public async Task DeleteChildAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteChildAsync started by:" + _username);

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
            await LogUsername();
            Log.Information("UpdateChildAsync started by:" + _username);

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
                _child.ModifiedBy = _username;

                await _childRepository.UpdateAsync(_child);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateChildAsync failed:" + ex.Message);
            }
        }

        public async Task<int> CreateChildAsync(ChildItemViewModel child)
        {
            await LogUsername();
            Log.Information("CreateChildAsync started by:" + _username);

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
                _child.CreatedBy = _username;
                _child.ModifiedDate = DateTime.Now;
                _child.ModifiedBy = _username;

                await _childRepository.AddAsync(_child);
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
            await LogUsername();
            Log.Information("GetChildItem started by:" + _username);

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
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

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
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

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
