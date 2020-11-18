using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
using Syncfusion.XlsIO;
using EDI.ApplicationCore.Models;

namespace EDI.Web.Services
{
    public class SharedService: ISharedService
    {
        private readonly ILogger<AccountService> _logger;
        private readonly IAsyncIdentityRepository _accountRepository;
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IAsyncRepository<Province> _provinceRepository;
        private readonly IAsyncRepository<FileImport> _fileRepository;
        private readonly IAsyncRepository<Site> _siteRepository;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<Year> _yearRepository;
        private readonly IAsyncRepository<Gender> _genderRepository;
        private readonly IAsyncRepository<School> _schoolRepository;
        private readonly IAsyncRepository<Teacher> _teacherRepository;
        private readonly IAsyncRepository<Child> _childRepository;
        private readonly IAsyncRepository<TeacherFeedbackForm> _feedbackRepository;
        private readonly IAsyncRepository<TeacherParticipationForm> _participationRepository;
        private readonly IAsyncRepository<Translation> _tranRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings POAppSettings { get; set; }
        private readonly ServiceContext _dbContext;
        private readonly AppIdentityDbContext _identityContext;
        private IHostEnvironment _hostingEnvironment;
        private readonly IEmailSender _emailSender;
        private UserSettings _userSettings { get; set; }
        private LanguageSettings _languageSettings { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }

        public SharedService(
            ILoggerFactory loggerFactory,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IAsyncRepository<Country> countryRepository,
            IAsyncRepository<Province> provinceRepository,
            IAsyncRepository<FileImport> fileRepository,
            IAsyncRepository<Site> siteRepository,
            IAsyncRepository<Coordinator> coordinatorRepository,
            IAsyncRepository<Gender> genderRepository,
            IAsyncRepository<Year> yearRepository,
            IAsyncRepository<School> schoolRepository,
            IAsyncRepository<Teacher> teacherRepository,
            IAsyncRepository<Child> childRepository,
            IAsyncRepository<TeacherFeedbackForm> feedbackRepository,
            IAsyncRepository<TeacherParticipationForm> participationRepository,
            IAsyncIdentityRepository accountRepository,
            IAsyncRepository<Translation> tranRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            IEmailSender emailSender,
            AuthenticationStateProvider authenticationStateProvider,
            ServiceContext dbContext,
            AppIdentityDbContext identityContext,
            UserSettings UserSettings,
            LanguageSettings languageSettings,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<AccountService>();
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
            _countryRepository = countryRepository;
            _provinceRepository = provinceRepository;
            _fileRepository = fileRepository;
            _tranRepository = tranRepository;
            _accountRepository = accountRepository;
            _siteRepository = siteRepository;
            _coordinatorRepository = coordinatorRepository;
            _genderRepository = genderRepository;
            _yearRepository = yearRepository;
            _schoolRepository = schoolRepository;
            _teacherRepository = teacherRepository;
            _childRepository = childRepository;
            _feedbackRepository = feedbackRepository;
            _participationRepository = participationRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _dbContext = dbContext;
            _identityContext = identityContext;
            _emailSender = emailSender;
            _userSettings = UserSettings;
            _languageSettings = languageSettings;
            POAppSettings = settings.Value;
        }

        public async Task<IEnumerable<SelectListItem>> GetCountries()
        {
            
            Log.Information("GetCountries started by:" + _userSettings.UserName);

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
            
            Log.Information("GetProvinces started by:" + _userSettings.UserName);

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

        public async Task<IEnumerable<SelectListItem>> GetSites()
        {
            
            Log.Information("GetSites started by:" + _userSettings.UserName);

            try
            {
                var sites = _siteRepository.ListAllSites().OrderBy(t => t.SiteNumber);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var site in sites)
                {
                    items.Add(new SelectListItem() { Value = site.Id.ToString(), Text = site.SiteNumber });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetSites failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetCoordinators()
        {
            
            Log.Information("GetCoordinators started by:" + _userSettings.UserName);

            try
            {
                var coordinators = _coordinatorRepository.ListAllCoordinators().OrderBy(t => t.CoordinatorName);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var coordinator in coordinators)
                {
                    items.Add(new SelectListItem() { Value = coordinator.Id.ToString(), Text = coordinator.CoordinatorName });
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

        public async Task<IEnumerable<SelectListItem>> GetYears()
        {
            
            Log.Information("GetYears started by:" + _userSettings.UserName);

            try
            {
                var years = _yearRepository.ListAllYears().OrderBy(t => t.Ediyear);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var year in years)
                {
                    items.Add(new SelectListItem() { Value = year.Id.ToString(), Text = year.Ediyear.Value.ToString() });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetYears failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetGenders()
        {
            
            Log.Information("GetGenders started by:" + _userSettings.UserName);

            try
            {
                var genders = _genderRepository.ListAllGenders().OrderBy(t => t.English);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var gender in genders)
                {
                    items.Add(new SelectListItem() { Value = gender.Id.ToString(), Text = gender.English });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetGenders failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetSchools(int siteid)
        {
            
            Log.Information("GetSchools started by:" + _userSettings.UserName);

            try
            {
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = "0", Text = "Choose One...", Selected = true }
                };

                if (siteid > 0)
                {
                    var filterSpecification = new SchoolFilterSpecification(siteid);
                    var school = await _schoolRepository.ListAsync(filterSpecification);

                    var ordered = school.OrderBy(t => t.SchoolName);

                    foreach (School sch in ordered)
                    {
                        items.Add(new SelectListItem() { Value = sch.Id.ToString(), Text = sch.SchoolName });
                    }
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetSchools failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetTeachers(int schoolid)
        {
            
            Log.Information("GetTeachers started by:" + _userSettings.UserName);

            try
            {
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                }; 
                
                if (schoolid > 0)
                {
                    var filterSpecification = new TeacherFilterSpecification(schoolid);
                    var teachers = await _teacherRepository.ListAsync(filterSpecification);

                    var ordered = teachers.OrderBy(t => t.TeacherName);

                    foreach (Teacher item in ordered)
                    {
                        items.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.TeacherName });
                    }
                }
                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetTeachers failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<ErrorViewModel> UploadFileData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file)
        {
            
            Log.Information("UploadFileData started by:" + _userSettings.UserName);
            ErrorViewModel error = new ErrorViewModel();

            string errormessage = string.Empty;
            string message = string.Empty;

            try
            {
                if (file.FileInfo.Size > 0)
                {
                    string folderName = "Upload";
                    string webRootPath = _hostingEnvironment.ContentRootPath + @"\wwwroot";
                    string newPath = Path.Combine(webRootPath, folderName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }

                    string fullPath = Path.Combine(newPath, "Customers.xlsx");

                    var comlumHeadrs = new string[]
                    {
                        "Site",
                        "Coordinator",
                        "Coordinator Email",
                        "School Name",
//                        "School Province",
                        "Teacher Name",
                        "Teacher Email",
                        "Child's Local ID",
//                        "Class_tm",
                        "Gender",
                        "DOB",
                        "Postal Code",
                        "EDI_ID"
                    };

                    using (Stream fileStream = file.Stream)
                    {
                        using (ExcelEngine excelEngine = new ExcelEngine())
                        {
                            // set the stream position to zero
                            fileStream.Position = 0;

                            Syncfusion.XlsIO.IWorkbook workbook = excelEngine.Excel.Workbooks.Open(fileStream, ExcelOpenType.Automatic, ExcelParseOptions.Default); ;

                            //Get the first worksheet in the workbook into IWorksheet
                            IWorksheet worksheet = workbook.Worksheets[0];

                            IRange firstrow = worksheet.Rows[0];

                            int cellCount = firstrow.LastColumn;

                            for (int j = 0; j < cellCount; j++)
                            {
                                if (j > 10)
                                    break;

                                var cell = firstrow.Cells[j];
                                if ((cell == null || string.IsNullOrWhiteSpace(cell.CalculatedValue)) || cell.CalculatedValue.ToLower() != comlumHeadrs[j].Trim().ToLower())
                                {
                                    errormessage = "This Excel file is invalid";

                                    error.message = message;
                                    error.errormessage = errormessage;
                                    return error;
                                }
                            }

                            //await _fileRepository.DeleteAllFileImports();
                            //await _fileRepository.ReseedFileImports();

                            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
                            optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
                            using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
                            {
                                int firstRow = worksheet.UsedRange.Row;
                                int lastRow = worksheet.UsedRange.LastRow;

                                for (int i = firstRow; i < lastRow; i++) //Read Excel File
                                {
                                    IRange row = worksheet.Rows[i];
                                    if (row == null) continue;
                                    if (row.IsBlank) continue;


                                    var site = row.Cells[0]?.CalculatedValue.Trim();

                                    var _file = new FileImport();

                                    _file.FileName = file.FileInfo.Name;
                                    _file.SiteName = site;
                                    _file.CoordinatorName = row.Cells[1]?.CalculatedValue.Trim();
                                    _file.CoordinatorEmail = row.Cells[2]?.CalculatedValue.Trim();
                                    _file.SchoolName = row.Cells[3]?.CalculatedValue.Trim();

                                    /*var province = row.Cells[4]?.CalculatedValue.Trim();
                                    if (string.IsNullOrEmpty(province))
                                    {
                                        _file.SchoolProvinceId = null;
                                    }
                                    else
                                    {
                                        //if (currency == "CAD")
                                        //    currency = "CAD - Canadian dollar";

                                        //var currencyid = servicecontext.Currency.Where(p => p.Name == currency).Select(p => p.Id).FirstOrDefault();

                                        _file.SchoolProvinceId = int.Parse(province);
                                    }*/
                                    _file.TeacherName = row.Cells[4]?.CalculatedValue.Trim();
                                    _file.TeacherEmail = row.Cells[5]?.CalculatedValue.Trim();
                                    _file.LocalId = row.Cells[6]?.CalculatedValue.Trim();
                                    /*var classtime = row.Cells[8]?.CalculatedValue.Trim();

                                    if (string.IsNullOrEmpty(classtime))
                                    {
                                        _file.ClassTime = null;
                                    }
                                    else
                                    {
                                        _file.ClassTime = byte.Parse(classtime);
                                    }
                                    */
                                    var gender = row.Cells[7]?.CalculatedValue.Trim();

                                    if (string.IsNullOrEmpty(gender))
                                    {
                                        _file.GenderId = null;
                                    }
                                    else
                                    {
                                        int genderid = 0;
                                        if (gender == "M")
                                        {
                                            genderid = servicecontext.Genders.Where(p => p.English == "Male").FirstOrDefault().Id;
                                        }
                                        else
                                        {
                                            genderid = servicecontext.Genders.Where(p => p.English == "Female").FirstOrDefault().Id;
                                        }

                                        _file.GenderId = genderid;
                                    }


                                    var dob = row.Cells[8]?.CalculatedValue.Trim();

                                    if (string.IsNullOrEmpty(dob))
                                    {
                                        _file.ChildDob = null;
                                    }
                                    else
                                    {
                                        _file.ChildDob = DateTime.Parse(dob);
                                    }

                                    _file.ChildPostalCodeZip = row.Cells[9]?.CalculatedValue.Trim();
                                    _file.ChildEdiid = row.Cells[10]?.CalculatedValue.Trim();


                                    int statusid = 0;
                                    statusid = servicecontext.FileImportStatuses.Where(p => p.English == "Imported").FirstOrDefault().Id;

                                    _file.FileImportStatusId = statusid;

                                    _file.ModifiedDate = DateTime.Now;
                                    _file.ModifiedBy = _userSettings.UserName;

                                    _file.CreatedDate = DateTime.Now;
                                    _file.CreatedBy = _userSettings.UserName;

                                    await _fileRepository.AddAsync(_file);

                                    error.message = "file has been imported successfully.";
                                }
                            }
                        }

                        if (string.IsNullOrEmpty(error.errormessage))
                        {
                            if (File.Exists(fullPath))
                            {
                                File.Delete(fullPath);
                            }

                            FileStream filestream = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
                            file.Stream.WriteTo(filestream);
                            filestream.Close();
                            file.Stream.Close();
                        }
                    }
                }
                else
                {
                    errormessage = "The file is invalid!";
                }

                return error;
            }
            catch (Exception ex)
            {
                Log.Error("UploadFileData failed:" + ex.Message);

                errormessage = "File imports failed. Please check the log file for more information.";

                error.message = message;
                error.errormessage = errormessage;
                return error;
            }
        }

        public async Task<ErrorViewModel> ProcessFileData()
        {
            
            Log.Information("UploadFileData started by:" + _userSettings.UserName);
            ErrorViewModel error = new ErrorViewModel();

            string errormessage = string.Empty;
            string message = string.Empty;
            List<string> messages = new List<string>();
            List<string> errormessages = new List<string>();

            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
                optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
                using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
                {
                    var alldata = _fileRepository.ListImportedData();

                    var processstatusid = servicecontext.FileImportStatuses.Where(p => p.English == "Processed").First().Id;

                    var totalcoordinators = 0;
                    var totalsites = 0;
                    var totalschools = 0;
                    var totalteachers = 0;
                    var totalstudents = 0;

                    foreach (var data in alldata)
                    {
                        var haserror = false;

                        if (string.IsNullOrEmpty(data.ChildEdiid))
                        {
                            errormessages.Add("FileImports data " + data.Id + ": Child Ediid is required.");
                            haserror = true;
                        }
                        else if (data.ChildEdiid.Length != 15)
                        {
                            errormessages.Add("FileImports data " + data.Id + ": Child Ediid is invalid.");
                            haserror = true;
                        }
                        else
                        {
                            ///<summary>process year
                            ///</summary>
                            string subyear = data.ChildEdiid.Substring(0, 2);
                            short numsubyear = short.Parse(subyear);

                            string currentyear = DateTime.Now.Year.ToString().Substring(2, 2);
                            short numcurrentyear = short.Parse(currentyear);

                            var ediyear = short.Parse("20" + subyear);

                            if (numsubyear > numcurrentyear)
                                ediyear = short.Parse("19" + subyear);

                            var years = servicecontext.Years.Where(p => p.Ediyear == ediyear);

                            int yearid = 0;

                            if (years == null || years.Count() == 0)
                            {
                                try
                                {
                                    var _year = new Year();

                                    _year.Ediyear = ediyear;
                                    _year.CreatedDate = DateTime.Now;
                                    _year.CreatedBy = _userSettings.UserName;
                                    _year.ModifiedDate = DateTime.Now;
                                    _year.ModifiedBy = _userSettings.UserName;

                                    await _yearRepository.AddAsync(_year);

                                    yearid = _year.Id;
                                }
                                catch (Exception ex)
                                {
                                    errormessages.Add("FileImports data " + data.Id + ": Create a year error: " + ex.Message);
                                    haserror = true;
                                }
                            }
                            else
                            {
                                yearid = years.First().Id;
                            }

                            ///<summary>process coordinator
                            ///</summary>
                            int coordinatorid = 0;
                            if (!string.IsNullOrEmpty(data.CoordinatorName) && !string.IsNullOrEmpty(data.CoordinatorEmail))
                            {
                                if (!ValidateExtension.IsEmailValid(data.CoordinatorEmail))
                                {
                                    errormessages.Add("FileImports data " + data.Id + ": Coordinator Email is invalid.");
                                    haserror = true;
                                }
                                else
                                {
                                    var coordinator = servicecontext.Coordinators.Where(p => p.CoordinatorName == data.CoordinatorName && p.Email == data.CoordinatorEmail).FirstOrDefault();

                                    if (coordinator == null)
                                    {

                                        var user = _identityContext.Users.Where(p => p.UserName == data.CoordinatorEmail).FirstOrDefault();
                                        string userid = string.Empty;

                                        if (user == null)
                                        {
                                            try
                                            {
                                                string[] names = data.CoordinatorName.Split(' ');
                                                string firstname = names[0];
                                                string lastname = names[1];

                                                var newuser = new ApplicationUser
                                                {
                                                    UserName = data.CoordinatorEmail,
                                                    Email = data.CoordinatorEmail,
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
                                                errormessages.Add("FileImports data " + data.Id + ": Create a user error: " + ex.Message);
                                                haserror = true;
                                            }
                                        }
                                        else
                                        {
                                            userid = user.Id;
                                        }

                                        try
                                        {
                                            var _coordinator = new Coordinator();

                                            _coordinator.UserId = userid;
                                            _coordinator.CoordinatorName = data.CoordinatorName;
                                            _coordinator.Email = data.CoordinatorEmail;
                                            _coordinator.YearId = yearid;
                                            _coordinator.CreatedDate = DateTime.Now;
                                            _coordinator.CreatedBy = _userSettings.UserName;
                                            _coordinator.ModifiedDate = DateTime.Now;
                                            _coordinator.ModifiedBy = _userSettings.UserName;

                                            await _coordinatorRepository.AddAsync(_coordinator);
                                            coordinatorid = _coordinator.Id;
                                            totalcoordinators++;
                                        }
                                        catch (Exception ex)
                                        {
                                            errormessages.Add("FileImports data " + data.Id + ": Create a coordinator error: " + ex.Message);
                                            haserror = true;
                                        }
                                    }
                                    else
                                    {
                                        coordinatorid = coordinator.Id;
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(data.CoordinatorName))
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Coordinator Name is required.");
                                haserror = true;
                            }
                            else if (string.IsNullOrEmpty(data.CoordinatorEmail))
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Coordinator Email is required.");
                                haserror = true;
                            }

                            ///<summary>process site
                            ///</summary>
                            int siteid = 0;
                            if (!string.IsNullOrEmpty(data.SiteName))
                            {
                                if (coordinatorid > 0)
                                {
                                    string sitenumber = data.ChildEdiid.Substring(4, 3);

                                    var site = servicecontext.Sites.Where(p => p.SiteNumber == sitenumber && p.SiteName == data.SiteName).FirstOrDefault();

                                    if (site == null)
                                    {
                                        try
                                        {
                                            var _site = new Site();

                                            _site.SiteNumber = sitenumber;
                                            _site.SiteName = data.SiteName;
                                            _site.CoordinatorId = coordinatorid;
                                            _site.YearId = yearid;
                                            _site.CreatedDate = DateTime.Now;
                                            _site.CreatedBy = _userSettings.UserName;
                                            _site.ModifiedDate = DateTime.Now;
                                            _site.ModifiedBy = _userSettings.UserName;

                                            await _siteRepository.AddAsync(_site);
                                            siteid = _site.Id;
                                            totalsites++;
                                        }
                                        catch (Exception ex)
                                        {
                                            errormessages.Add("FileImports data " + data.Id + ": Create a site error: " + ex.Message);
                                            haserror = true;
                                        }
                                    }
                                    else
                                    {
                                        siteid = site.Id;
                                    }
                                }
                            }
                            else
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Site Name is required.");
                                haserror = true;
                            }

                            ///<summary>process school
                            ///</summary>
                            int schoolid = 0;
                            if (!string.IsNullOrEmpty(data.SchoolName))
                            {
                                if (siteid > 0)
                                {
                                    string schoolnumber = data.ChildEdiid.Substring(7, 3);

                                    var school = servicecontext.Schools.Where(p => p.SiteId == siteid && p.SchoolNumber == schoolnumber && p.SchoolName == data.SchoolName).FirstOrDefault();

                                    if (school == null)
                                    {
                                        try
                                        {
                                            var _school = new School();

                                            _school.SchoolNumber = schoolnumber;
                                            _school.SchoolName = data.SchoolName;

                                            var provinceedicodestring = data.ChildEdiid.Substring(2, 2);
                                            var provinceedicode = int.Parse(provinceedicodestring);
                                            var countryid = servicecontext.Provinces.Where(p => p.EDICode == provinceedicode).FirstOrDefault().CountryID;
                                            var provinceid = servicecontext.Provinces.Where(p => p.EDICode == provinceedicode).FirstOrDefault().Id;

                                            if(provinceid == 0)
                                            {
                                                errormessages.Add("FileImports data " + data.Id + ": Province is required.");
                                                haserror = true;
                                            }
                                            else
                                            {
                                                _school.CountryId = countryid;
                                                _school.ProvinceId = provinceid;
                                                _school.SiteId = siteid;
                                                _school.YearId = yearid;
                                                _school.CreatedDate = DateTime.Now;
                                                _school.CreatedBy = _userSettings.UserName;
                                                _school.ModifiedDate = DateTime.Now;
                                                _school.ModifiedBy = _userSettings.UserName;

                                                await _schoolRepository.AddAsync(_school);
                                                schoolid = _school.Id;
                                                totalschools++;
                                            }                                            
                                        }
                                        catch (Exception ex)
                                        {
                                            errormessages.Add("FileImports data " + data.Id + ": Create a school error: " + ex.Message);
                                            haserror = true;
                                        }
                                    }
                                    else
                                    {
                                        schoolid = school.Id;
                                    }
                                }
                            }
                            else
                            {
                                errormessages.Add("FileImports data " + data.Id + ": School Name is required.");
                                haserror = true;
                            }

                            ///<summary>process teacher
                            ///</summary>
                            int teacherid = 0;
                            if (!string.IsNullOrEmpty(data.TeacherName) && !string.IsNullOrEmpty(data.TeacherEmail))
                            {
                                if (!ValidateExtension.IsEmailValid(data.TeacherEmail))
                                {
                                    errormessages.Add("FileImports data " + data.Id + ": Teacher Email is invalid.");
                                    haserror = true;
                                }
                                else
                                {
                                    if (schoolid > 0)
                                    {
                                        string teachernumber = data.ChildEdiid.Substring(10, 2);
                                        var teacher = servicecontext.Teachers.Where(p => p.TeacherName == data.TeacherName && p.Email == data.TeacherEmail).FirstOrDefault();

                                        if (teacher == null)
                                        {
                                            var user = _identityContext.Users.Where(p => p.UserName == data.TeacherEmail).FirstOrDefault();
                                            string userid = string.Empty;

                                            if (user == null)
                                            {
                                                try
                                                {
                                                    string[] names = data.TeacherName.Split(' ');
                                                    string firstname = names[0];
                                                    string lastname = names[1];

                                                    var newuser = new ApplicationUser
                                                    {
                                                        UserName = data.TeacherEmail,
                                                        Email = data.TeacherEmail,
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
                                                    errormessages.Add("FileImports data " + data.Id + ": Create a user error: " + ex.Message);
                                                    haserror = true;
                                                }
                                            }
                                            else
                                            {
                                                userid = user.Id;
                                            }

                                            try
                                            {
                                                var _teacher = new Teacher();

                                                _teacher.UserId = userid;
                                                _teacher.TeacherNumber = teachernumber;
                                                _teacher.TeacherName = data.TeacherName;
                                                _teacher.Email = data.TeacherEmail;
                                                _teacher.SchoolId = schoolid;
                                                _teacher.YearId = yearid;
                                                _teacher.CreatedDate = DateTime.Now;
                                                _teacher.CreatedBy = _userSettings.UserName;
                                                _teacher.ModifiedDate = DateTime.Now;
                                                _teacher.ModifiedBy = _userSettings.UserName;

                                                await _teacherRepository.AddAsync(_teacher);
                                                teacherid = _teacher.Id;
                                                totalteachers++;

                                                var _teacherFeedbackForms = new TeacherFeedbackForm();
                                                _teacherFeedbackForms.TeacherId = teacherid;
                                                _teacherFeedbackForms.YearId = yearid;
                                                _teacherFeedbackForms.CreatedDate = DateTime.Now;
                                                _teacherFeedbackForms.CreatedBy = _userSettings.UserName;
                                                _teacherFeedbackForms.ModifiedDate = DateTime.Now;
                                                _teacherFeedbackForms.ModifiedBy = _userSettings.UserName;

                                                await _feedbackRepository.AddAsync(_teacherFeedbackForms);

                                                var _teacherParticipationForms = new TeacherParticipationForm();
                                                _teacherParticipationForms.TeacherId = teacherid;
                                                _teacherParticipationForms.YearId = yearid;
                                                _teacherParticipationForms.CreatedDate = DateTime.Now;
                                                _teacherParticipationForms.CreatedBy = _userSettings.UserName;
                                                _teacherParticipationForms.ModifiedDate = DateTime.Now;
                                                _teacherParticipationForms.ModifiedBy = _userSettings.UserName;

                                                await _participationRepository.AddAsync(_teacherParticipationForms);
                                            }
                                            catch (Exception ex)
                                            {
                                                errormessages.Add("FileImports data " + data.Id + ": Create a teacher error: " + ex.Message);
                                                haserror = true;
                                            }
                                        }
                                        else
                                        {
                                            teacherid = teacher.Id;
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(data.TeacherName))
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Teacher Name is required.");
                                haserror = true;
                            }
                            else if (string.IsNullOrEmpty(data.TeacherEmail))
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Teacher Email is required.");
                                haserror = true;
                            }

                            ///<summary>process student
                            ///</summary>
                            int childid = 0;
                            if (!string.IsNullOrEmpty(data.LocalId))
                            {
                                if (teacherid > 0)
                                {
                                    var child = servicecontext.Children.Where(p => p.LocalId == data.LocalId && p.Ediid == data.ChildEdiid).FirstOrDefault();

                                    if (child == null)
                                    {
                                        try
                                        {
                                            string childnumber = data.ChildEdiid.Substring(13, 2);
                                            var _child = new Child();

                                            _child.Ediid = data.ChildEdiid;
                                            _child.LocalId = data.LocalId;
                                            _child.ChildNumber = childnumber;
                                            _child.YearId = yearid;
                                            _child.TeacherId = teacherid;
                                            _child.GenderId = data.GenderId;
                                            _child.Dob = data.ChildDob;
                                            _child.PostalCodeZip = data.ChildPostalCodeZip;
                                            _child.CreatedDate = DateTime.Now;
                                            _child.CreatedBy = _userSettings.UserName;
                                            _child.ModifiedDate = DateTime.Now;
                                            _child.ModifiedBy = _userSettings.UserName;

                                            await _childRepository.AddAsync(_child);

                                            childid = _child.Id;
                                            totalstudents++;
                                        }
                                        catch (Exception ex)
                                        {
                                            errormessages.Add("FileImports data " + data.Id + ": Create a student error: " + ex.Message);
                                            haserror = true;
                                        }
                                    }
                                    else
                                    {
                                        childid = child.Id;
                                    }
                                }
                            }
                            else
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Local Id is required.");
                                haserror = true;
                            }
                        }

                        if (!haserror)
                        {
                            data.FileImportStatusId = processstatusid;
                            data.ModifiedDate = DateTime.Now;
                            data.ModifiedBy = _userSettings.UserName;

                            await _fileRepository.UpdateAsync(data);
                        }
                    }

                    if (totalcoordinators > 0)
                    {
                        if (totalcoordinators > 1)
                        {
                            messages.Add("Total " + totalcoordinators + " new coordinators were inserted.");
                        }
                        else
                        {
                            messages.Add("Total 1 new coordinator were inserted.");
                        }
                    }

                    if (totalsites > 0)
                    {
                        if (totalsites > 1)
                        {
                            messages.Add("Total " + totalsites + " new sites were inserted.");
                        }
                        else
                        {
                            messages.Add("Total 1 new site were inserted.");
                        }
                    }

                    if (totalschools > 0)
                    {
                        if (totalschools > 1)
                        {
                            messages.Add("Total " + totalschools + " new schools were inserted.");
                        }
                        else
                        {
                            messages.Add("Total 1 new school were inserted.");
                        }
                    }

                    if (totalteachers > 0)
                    {
                        if (totalteachers > 1)
                        {
                            messages.Add("Total " + totalteachers + " new teachers were inserted.");
                        }
                        else
                        {
                            messages.Add("Total 1 new teacher were inserted.");
                        }
                    }

                    if (totalstudents > 0)
                    {
                        if (totalstudents > 1)
                        {
                            messages.Add("Total " + totalstudents + " new students were inserted.");
                        }
                        else
                        {
                            messages.Add("Total 1 new student were inserted.");
                        }
                    }
                }
                error.messages = messages;
                error.errormessages = errormessages;

                return error;
            }
            catch (Exception ex)
            {
                Log.Error("ProcessFileData failed:" + ex.Message);

                errormessage = "Processing data failed. Please check the log file for more information.";
                errormessages.Add("ProcessFileData failed:" + ex.Message);
                error.message = message;
                error.errormessage = errormessage;
                error.errormessages = errormessages;
                return error;
            }
        }

        public async Task<ErrorViewModel> UploadTranslationData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file)
        {
            Log.Information("UploadTranslationData started by:" + _userSettings.UserName);
            ErrorViewModel error = new ErrorViewModel();

            string errormessage = string.Empty;
            string message = string.Empty;

            try
            {
                if (file.FileInfo.Size > 0)
                {
                    string folderName = "Upload";
                    string webRootPath = _hostingEnvironment.ContentRootPath + @"\wwwroot";
                    string newPath = Path.Combine(webRootPath, folderName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }

                    string fullPath = Path.Combine(newPath, "Translation.xlsx");

                    var comlumHeadrs = new string[]
                    {
                        "English",
                        "French"
                    };

                    using (Stream fileStream = file.Stream)
                    {
                        using (ExcelEngine excelEngine = new ExcelEngine())
                        {
                            // set the stream position to zero
                            fileStream.Position = 0;

                            Syncfusion.XlsIO.IWorkbook workbook = excelEngine.Excel.Workbooks.Open(fileStream, ExcelOpenType.Automatic, ExcelParseOptions.Default); ;

                            //Get the first worksheet in the workbook into IWorksheet
                            IWorksheet worksheet = workbook.Worksheets[0];

                            IRange firstrow = worksheet.Rows[0];

                            int cellCount = firstrow.LastColumn;

                            for (int j = 0; j < cellCount; j++)
                            {
                                if (j > 1)
                                    break;

                                var cell = firstrow.Cells[j];
                                if ((cell == null || string.IsNullOrWhiteSpace(cell.CalculatedValue)) || cell.CalculatedValue.ToLower() != comlumHeadrs[j].Trim().ToLower())
                                {
                                    errormessage = "This Excel file is invalid";

                                    error.message = message;
                                    error.errormessage = errormessage;
                                    return error;
                                }
                            }

                            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
                            optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
                            using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
                            {
                                int firstRow = worksheet.UsedRange.Row;
                                int lastRow = worksheet.UsedRange.LastRow;

                                for (int i = firstRow; i < lastRow; i++) //Read Excel File
                                {
                                    IRange row = worksheet.Rows[i];
                                    if (row == null) continue;
                                    if (row.IsBlank) continue;

                                    var english = row.Cells[0]?.CalculatedValue.Trim();

                                    var translate = servicecontext.Translations.Where(p => p.English == english).FirstOrDefault();
                                    
                                    if(translate == null)
                                    {
                                        var _translate = new Translation();
                                        _translate.English = english;
                                        _translate.French = row.Cells[1]?.CalculatedValue.Trim();
                                        _translate.CreatedDate = DateTime.Now;
                                        _translate.CreatedBy = _userSettings.UserName;
                                        _translate.ModifiedDate = DateTime.Now;
                                        _translate.ModifiedBy = _userSettings.UserName;

                                        await _tranRepository.AddAsync(_translate);

                                        error.message = "file has been imported successfully.";
                                    }
                                    else
                                    {
                                        var french = row.Cells[1]?.CalculatedValue.Trim();
                                        if (!string.IsNullOrEmpty(french) && translate.French.ToLower().Trim() != french.ToLower())
                                        {
                                            translate.French = french;

                                            translate.CreatedDate = DateTime.Now;
                                            translate.CreatedBy = _userSettings.UserName;
                                            translate.ModifiedDate = DateTime.Now;
                                            translate.ModifiedBy = _userSettings.UserName;

                                            await _tranRepository.UpdateAsync(translate);

                                            error.message = "file has been imported successfully.";
                                        }
                                    }
                                }
                            }
                        }

                        if (string.IsNullOrEmpty(error.errormessage))
                        {
                            if (File.Exists(fullPath))
                            {
                                File.Delete(fullPath);
                            }

                            FileStream filestream = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
                            file.Stream.WriteTo(filestream);
                            filestream.Close();
                            file.Stream.Close();
                        }
                    }
                }
                else
                {
                    errormessage = "The file is invalid!";
                }

                return error;
            }
            catch (Exception ex)
            {
                Log.Error("UploadTranslationData failed:" + ex.Message);

                errormessage = "File imports failed. Please check the log file for more information.";

                error.message = message;
                error.errormessage = errormessage;
                return error;
            }
        }

        public string GetTranslate(string english)
        {
            if (string.IsNullOrEmpty(english))
                return string.Empty;
            else
            {
                if (_userSettings.Language == "French")
                {
                    var translate = _languageSettings.Translations.Where(e => e.English == english).FirstOrDefault();
                    if (translate == null || string.IsNullOrEmpty(translate.French))
                        return english;
                    else
                        return translate.French;
                }
                else
                    return english;
            }            
        }

        public string GetImagePath()
        {
            string folderName = "UploadImages";
            string webRootPath = _hostingEnvironment.ContentRootPath + @"\wwwroot";
            string newPath = Path.Combine(webRootPath, folderName);

            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            return folderName;
        }

        public async Task<string> SendEmail(EmailModel EmailModel)
        {
            string message = string.Empty;

            EmailModel.To = POAppSettings.EmailTo;

            message = await _emailSender.SendEmailAsync(EmailModel);

            return message;
        }
    }
}
