using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class SharedService: ISharedService
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

        public SharedService(
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

        public async Task<IEnumerable<SelectListItem>> GetCountries()
        {
            await LogUsername();
            Log.Information("GetCountries started by:" + _username);

            try
            {
                var countries = await _countryRepository.ListAllAsync();

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = "0", Text = "Choose One...", Selected = true }
                };
                var ordered = countries.OrderBy(t => t.English);

                foreach (Country org in ordered)
                {
                    items.Add(new SelectListItem() { Value = org.Id.ToString(), Text = org.English });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetCountries failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetProvinces(int countryid)
        {
            await LogUsername();
            Log.Information("GetProvinces started by:" + _username);

            try
            {
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = "0", Text = "Choose One...", Selected = true }
                };

                if (countryid > 0)
                {
                    var filterSpecification = new ProvinceFilterSpecification(countryid);
                    var province = await _provinceRepository.ListAsync(filterSpecification);

                    var ordered = province.OrderBy(t => t.English);

                    foreach (Province prov in ordered)
                    {
                        items.Add(new SelectListItem() { Value = prov.Id.ToString(), Text = prov.English });
                    }
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetProvinces failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }
    }
}
