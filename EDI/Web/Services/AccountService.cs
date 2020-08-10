﻿using Microsoft.AspNetCore.Mvc.Rendering;
using EDI.ApplicationCore.Entities;
using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Specifications;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using EDI.Web.Models;
using EDI.Web.Interfaces;
using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using EDI.Infrastructure.Identity;
using EDI.Infrastructure.Interfaces;
using Serilog;
using System.Net.Mail;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using EDI.Web.Lib;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using EDI.Web.Extensions;
using EDI.Infrastructure.Data;

namespace EDI.Web.Services
{
    public class AccountService: IAccountService
    {
        private readonly ILogger<AccountService> _logger;
        private readonly IAsyncIdentityRepository _accountRepository;
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IAsyncRepository<Province> _provinceRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings POAppSettings { get; set; }
        private readonly ServiceContext _dbContext;
        private readonly AppIdentityDbContext _identityContext;
        private IHostEnvironment _hostingEnvironment;
        private readonly IEmailSender _emailSender;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }

        public AccountService(
            ILoggerFactory loggerFactory,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IAsyncRepository<Country> countryRepository,
            IAsyncRepository<Province> provinceRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            IEmailSender emailSender,
            AuthenticationStateProvider authenticationStateProvider,
            ServiceContext dbContext,
            AppIdentityDbContext identityContext,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<AccountService>();
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
            _countryRepository = countryRepository;
            _provinceRepository = provinceRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _dbContext = dbContext;
            _identityContext = identityContext;
            _emailSender = emailSender;
            POAppSettings = settings.Value;
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

        public async Task CreateAccountAsync(AccountItemViewModel account)
        {
            await LogUsername();
            Log.Information("CreateAccountAsync started by:" + _username);

            try
            {
                if (!string.IsNullOrEmpty(account.Email))
                {
                    if (!ValidateExtension.IsEmailValid(account.Email))
                    {
                        Log.Error("Email: " + account.Email + " is invalid.");
                        return;
                    }
                }

                var user = new ApplicationUser 
                            { 
                                UserName = account.Email, 
                                Email = account.Email, 
                                PhoneNumber = account.PhoneNumber, 
                                FirstName = account.FirstName, 
                                LastName = account.LastName, 
                                CountryID = account.CountryID,
                                ProvinceID = account.ProvinceID
                };
                var result = await _userManager.CreateAsync(user);

                if (!string.IsNullOrEmpty(account.RoleID))
                {
                    var role = await _accountRepository.GetRoleByIdAsync(account.RoleID);
                    await _userManager.AddToRoleAsync(user, role.Name);
                }

                if (result.Succeeded)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = _urlHelper.EmailConfirmationLink(user.Id, code, account.Scheme);
                    var callbackUrl = @"htts://fanout.phri.ca";
                    await _emailSender.SendEmailConfirmationAsync(account.Email, callbackUrl, user.FirstName);

                    _logger.LogInformation("User created a new account with password.");
                }
            }
            catch (Exception ex)
            {
                Log.Error("CreateAccount failed:" + ex.Message);
            }

        }

        public async Task DeleteAccountAsync(string Id)
        {
            await LogUsername();
            Log.Information("DeleteAccountAsync started by:" + _username);

            try
            {
                var account = await _accountRepository.GetByIdAsync(Id);

                await _accountRepository.DeleteAsync(account);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteAccountAsync failed:" + ex.Message);
            }
        }

        public async Task UnlockAccountAsync(string Id)
        {
            await LogUsername();
            Log.Information("UnlockAccountAsync started by:" + _username);

            try
            {
                var account = await _accountRepository.GetByIdAsync(Id);

                account.LockoutEnabled = false;
                account.LockoutEnd = DateTime.Now;

                await _accountRepository.UpdateAsync(account);
            }
            catch (Exception ex)
            {
                Log.Error("UnlockAccountAsync failed:" + ex.Message);
            }
        }

        public async Task LockAccountAsync(string Id)
        {
            await LogUsername();
            Log.Information("LockAccountAsync started by:" + _username);

            try
            {
                var account = await _accountRepository.GetByIdAsync(Id);

                account.LockoutEnabled = true;
                account.LockoutEnd = null;

                await _accountRepository.UpdateAsync(account);
            }
            catch (Exception ex)
            {
                Log.Error("LockAccountAsyncW failed:" + ex.Message);
            }
        }

        public async Task<AccountItemViewModel> GetAccountItem(string accountId)
        {
            await LogUsername();
            Log.Information("GetAccountItem started by:" + _username);

            try
            {
                var account = await _accountRepository.GetByIdAsync(accountId);

                var vm = new AccountItemViewModel()
                {
                    Id = account.Id,
                    FirstName = account.FirstName,
                    LastName = account.LastName,
                    Email = account.Email,
                    EmailConfirmed = account.EmailConfirmed,
                    NormalizedEmail = account.NormalizedEmail,
                    PhoneNumber = account.PhoneNumber,
                    PhoneNumberConfirmed = account.PhoneNumberConfirmed,
                    UserName = account.UserName,
                    LockoutEnabled = account.LockoutEnabled,
                    LockoutEnd = account.LockoutEnd,
                    Lockout = account.LockoutEnabled == true ? "Yes" : "No",
                    CountryID = account.CountryID,
                    Country = account.CountryID.HasValue ? _countryRepository.GetByIdAsync(account.CountryID.Value).Result.Name : string.Empty,
                    ProvinceID = account.ProvinceID,
                    Province = account.ProvinceID.HasValue ? _provinceRepository.GetByIdAsync(account.ProvinceID.Value).Result.Name : string.Empty
                };

                vm.Roles = await GetRoles();
                var roles = await _userManager.GetRolesAsync(account);

                if (roles != null && roles.Count > 0)
                    vm.RoleID = _accountRepository.GetRoleIDByname(roles.First());

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetAccountItem failed:" + ex.Message);

                var vm = new AccountItemViewModel();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetRoles()
        {
            await LogUsername();
            Log.Information("GetRoles started by:" + _username);

            try
            {
                var roles = _accountRepository.ListAllRoles().OrderBy(t => t.Name);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                var ordered = roles.OrderBy(t => t.Name);

                foreach (IdentityRole role in ordered)
                {
                    items.Add(new SelectListItem() { Value = role.Id, Text = role.Name });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetRoles failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetUsers()
        {
            await LogUsername();
            Log.Information("GetUsers started by:" + _username);

            try
            {
                var users = _accountRepository.ListAllUsers().OrderBy(t => t.FirstName);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                var ordered = users.OrderBy(t => t.FirstName);

                foreach (ApplicationUser user in ordered)
                {
                    items.Add(new SelectListItem() { Value = user.Id, Text = user.FirstName + " " + user.LastName});
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetUsers failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetCoordinators()
        {
            await LogUsername();
            Log.Information("GetCoordinators started by:" + _username);

            try
            {
                var users = _accountRepository.ListAllUsers().OrderBy(t => t.FirstName);

                var role = _identityContext.Roles.Where(p => p.Name == "Coordinator").FirstOrDefault();

                var coordusers = _identityContext.UserRoles.Where(p => p.RoleId == role.Id).ToList();

                var userlist = new List<ApplicationUser>();

                foreach(var user in users)
                {
                    foreach(var coorduser in coordusers)
                    {
                        if(user.Id == coorduser.UserId)
                        {
                            userlist.Add(user);
                        }
                    }
                }
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                var ordered = userlist.OrderBy(t => t.FirstName);

                foreach (ApplicationUser user in ordered)
                {
                    items.Add(new SelectListItem() { Value = user.Id, Text = user.FirstName + " " + user.LastName });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetCoordinators failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public int GetDuplicateCount(string email)
        {
            try
            {
                var totalItems = _accountRepository.GetDuplicateCount(email);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);

                return -1;
            }
        }

        public int GetOtherDuplicateCount(string email, string accountId)
        {
            try
            {
                var totalItems = _accountRepository.GetOtherDuplicateCount(email, accountId);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetOtherDuplicateCount failed:" + ex.Message);

                return -1;
            }
        }

        public async Task UpdateAccountAsync(AccountItemViewModel account)
        {
            await LogUsername();
            Log.Information("UpdateAccountAsync started by:" + _username);

            try
            {
                var _account = await _accountRepository.GetByIdAsync(account.Id);

                _account.LastName = account.LastName;
                _account.FirstName = account.FirstName;
                //_account.OrganizationId = account.OrganizationId;
                _account.CountryID = account.CountryID;
                _account.ProvinceID = account.ProvinceID;
                _account.Email = account.Email;
                _account.PhoneNumber = account.PhoneNumber;

                if (!string.IsNullOrEmpty(account.Password))
                {
                    var newPassword = _userManager.PasswordHasher.HashPassword(_account, account.Password);
                    _account.PasswordHash = newPassword;
                }

                if (!string.IsNullOrEmpty(account.RoleID))
                {
                    var roles = await _userManager.GetRolesAsync(_account);
                    await _userManager.RemoveFromRolesAsync(_account, roles);

                    var role = await _accountRepository.GetRoleByIdAsync(account.RoleID);
                    await _userManager.AddToRoleAsync(_account, role.Name);
                }

                await _userManager.UpdateAsync(_account);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateAccountAsync failed:" + ex.Message);
            }
        }

        public async Task<AccountItemViewModel> GetProfile()
        {
            await LogUsername();
            Log.Information("GetProfile started by:" + _username);

            try
            {
                var account = _identityContext.Users.Where(p=> p.UserName == _username).FirstOrDefault();

                var vm = new AccountItemViewModel()
                {
                    Id = account.Id,
                    FirstName = account.FirstName,
                    LastName = account.LastName,
                    Email = account.Email,
                    NormalizedEmail = account.NormalizedEmail,
                    PhoneNumber = account.PhoneNumber,
                    UserName = account.UserName,
                    LockoutEnabled = account.LockoutEnabled,
                    LockoutEnd = account.LockoutEnd,
                    CountryID = account.CountryID,
                    ProvinceID = account.ProvinceID
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetProfile failed:" + ex.Message);

                var vm = new AccountItemViewModel();

                return vm;
            }
        }

        public async Task DeleteRoleAsync(string Id)
        {
            await LogUsername();
            Log.Information("DeleteRoleAsync started by:" + _username);

            try
            {
                var role = await _accountRepository.GetRoleByIdAsync(Id);

                await _accountRepository.DeleteRoleAsync(role);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteRoleAsync failed:" + ex.Message);
            }
        }

        public int GetDuplicateRoleCount(string name)
        {
            try
            {
                var totalItems = _accountRepository.GetDuplicateRoleCount(name);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateRoleCount failed:" + ex.Message);

                return -1;
            }
        }

        public int GetDuplicateRoleCount(string name, string roleid)
        {
            try
            {
                var totalItems = _accountRepository.GetDuplicateRoleCount(name, roleid);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateRoleCount failed:" + ex.Message);

                return -1;
            }
        }
        public async Task UpdateRoleAsync(RoleItemViewModel role)
        {
            await LogUsername();
            Log.Information("UpdateRoleAsync started by:" + _username);

            try
            {
                var _role = await _accountRepository.GetRoleByIdAsync(role.Id);

                _role.Name = role.Name;

                await _roleManager.UpdateAsync(_role);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateRoleAsync failed:" + ex.Message);
            }
        }
        public async Task<RoleItemViewModel> GetRoleItem(string roleid)
        {
            await LogUsername();
            Log.Information("GetRoleItem started by:" + _username);

            try
            {
                var role = await _accountRepository.GetRoleByIdAsync(roleid);

                var vm = new RoleItemViewModel()
                {
                    Id = role.Id,
                    Name = role.Name
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetRoleItem failed:" + ex.Message);

                var vm = new RoleItemViewModel();

                return vm;
            }
        }

        public async Task CreateRoleAsync(RoleItemViewModel role)
        {
            await LogUsername();
            Log.Information("CreateRoleAsync started by:" + _username);

            try
            {
                var _role = new IdentityRole
                {
                    Name = role.Name
                };
                await _roleManager.CreateAsync(_role);
            }
            catch (Exception ex)
            {
                Log.Error("CreateRoleAsync failed:" + ex.Message);
            }
        }
    }
}
