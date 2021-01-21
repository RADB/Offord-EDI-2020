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
using EDI.Infrastructure.Data;

namespace EDI.Web.Services
{
    public class CoordinatorService : ICoordinatorService
    {
        private readonly ILogger<CoordinatorService> _logger;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;
        private readonly ServiceContext _dbContext;
        private readonly AppIdentityDbContext _identityContext;
        private readonly UserManager<EDIApplicationUser> _userManager;
        private UserSettings _userSettings { get; set; }
        private readonly ISharedService _sharedService;

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public CoordinatorService(
            UserManager<EDIApplicationUser> userManager,
            ILoggerFactory loggerFactory,
            IAsyncRepository<Coordinator> coordinatorRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            ServiceContext dbContext,
            AppIdentityDbContext identityContext,
            ISharedService sharedService,
            UserSettings UserSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<CoordinatorService>();
            _httpContextAccessor = httpContextAccessor;
            _coordinatorRepository = coordinatorRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _userManager = userManager;
            _dbContext = dbContext;
            _identityContext = identityContext;
            _sharedService = sharedService;
            _userSettings = UserSettings;
            EDIppSettings = settings.Value;
        }

        public async Task DeleteCoordinatorAsync(int Id)
        {
            
            _sharedService.WriteLogs("DeleteCoordinatorAsync started by:" + _userSettings.UserName, true);

            try
            {
                var coordinator = await _coordinatorRepository.GetByIdAsync(Id);

                Guard.Against.NullCoordinator(Id, coordinator);

                await _coordinatorRepository.DeleteAsync(coordinator);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("DeleteCoordinatorAsync failed:" + ex.Message, false);
            }
        }

        public async Task UpdateCoordinatorAsync(CoordinatorItemViewModel coordinator)
        {
            
            _sharedService.WriteLogs("UpdateCoordinatorAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _coordinator = await _coordinatorRepository.GetByIdAsync(coordinator.Id);

                Guard.Against.NullCoordinator(coordinator.Id, _coordinator);

                //_coordinator.UserId = coordinator.UserId;
                _coordinator.CoordinatorName = coordinator.CoordinatorName;
                _coordinator.Description = coordinator.Description;
                _coordinator.YearId = coordinator.YearId;
                _coordinator.Email = coordinator.Email;
                _coordinator.PhoneNumber = coordinator.PhoneNumber;
                _coordinator.ModifiedDate = DateTime.Now;
                _coordinator.ModifiedBy = _userSettings.UserName;

                await _coordinatorRepository.UpdateAsync(_coordinator);
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("UpdateCoordinatorAsync failed:" + ex.Message, false);
            }
        }

        public async Task<int> CreateCoordinatorAsync(CoordinatorItemViewModel coordinator)
        {
            
            _sharedService.WriteLogs("CreateCoordinatorAsync started by:" + _userSettings.UserName, true);

            try
            {
                var _coordinator = new Coordinator();

                var user = _identityContext.Users.Where(p => p.UserName == coordinator.Email).FirstOrDefault();
                string userid = string.Empty;

                if (user == null)
                {
                    try
                    {
                        string[] names = coordinator.CoordinatorName.Split(' ');
                        string firstname = names[0];
                        string lastname = names[1];

                        var newuser = new EDIApplicationUser
                        {
                            UserName = coordinator.Email,
                            Email = coordinator.Email,
                            FirstName = firstname,
                            LastName = lastname
                        };
                        var result = await _userManager.CreateAsync(newuser);

                        var role = _identityContext.Roles.Where(p => p.Name == "Coordinator").FirstOrDefault();

                        await _userManager.AddToRoleAsync(newuser, role.Name);

                        userid = newuser.Id;
                    }
                    catch (Exception ex)
                    {
                        _sharedService.WriteLogs("CreateCoordinatorAsync failed:" + ex.Message, false);
                    }
                }
                else
                {
                    userid = user.Id;
                }

                _coordinator.UserId = userid;
                _coordinator.CoordinatorName = coordinator.CoordinatorName;
                _coordinator.Description = coordinator.Description;
                _coordinator.YearId = coordinator.YearId;
                _coordinator.Email = coordinator.Email;
                _coordinator.PhoneNumber = coordinator.PhoneNumber;
                _coordinator.CreatedDate = DateTime.Now;
                _coordinator.CreatedBy = _userSettings.UserName;
                _coordinator.ModifiedDate = DateTime.Now;
                _coordinator.ModifiedBy = _userSettings.UserName;

                await _coordinatorRepository.AddAsync(_coordinator);
                return _coordinator.Id;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("CreateCoordinatorAsync failed:" + ex.Message, false);
                return 0;
            }
        }

        public async Task<CoordinatorItemViewModel> GetCoordinatorItem(int coordinatorId)
        {
            
            _sharedService.WriteLogs("GetCoordinatorItem started by:" + _userSettings.UserName, true);

            try
            {
                var coordinator = await _coordinatorRepository.GetByIdAsync(coordinatorId);

                Guard.Against.NullCoordinator(coordinatorId, coordinator);

                var vm = new CoordinatorItemViewModel()
                {
                    Id = coordinator.Id,
                    UserId = coordinator.UserId,
                    CoordinatorName = coordinator.CoordinatorName,
                    Description = coordinator.Description,
                    YearId = coordinator.YearId,
                    Email = coordinator.Email,
                    PhoneNumber = coordinator.PhoneNumber,
                    CreatedDate = coordinator.CreatedDate,
                    CreatedBy = coordinator.CreatedBy,
                    ModifiedDate = coordinator.ModifiedDate,
                    ModifiedBy = coordinator.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetCoordinatorItem failed:" + ex.Message, false);

                var vm = new CoordinatorItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string name, string email)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new CoordinatorFilterSpecification(name, email);

                var totalItems = await _coordinatorRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                _sharedService.WriteLogs("GetDuplicateCount failed:" + ex.Message, false);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string name, string email, int id)
        {
            
            _sharedService.WriteLogs("GetDuplicateCount started by:" + _userSettings.UserName, true);

            try
            {
                var filterSpecification = new CoordinatorFilterSpecification(name, email, id);

                var totalItems = await _coordinatorRepository.CountAsync(filterSpecification);

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
