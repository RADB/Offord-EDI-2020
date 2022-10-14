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
using static EDI.Web.Data.Enumerations;
using System.Linq.Dynamic.Core;
using EDI.Web.Data;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Dynamic;

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
        private readonly IAsyncRepository<LookupSetOption> _lookupSetOptionRepository;
        private readonly IAsyncRepository<Teacher> _teacherRepository;
        private readonly IAsyncRepository<Child> _childRepository;
        private readonly IAsyncRepository<FileImport> _fileImportRepository;
        private readonly IAsyncRepository<QuestionnairesDataDemographic> _questionnairesDataDemographic;
        private readonly IAsyncRepository<QuestionnairesDataSectionA> _questionnairesDataSectionA;
        private readonly IAsyncRepository<QuestionnairesDataSectionB> _questionnairesDataSectionB;
        private readonly IAsyncRepository<QuestionnairesDataSectionC> _questionnairesDataSectionC;
        private readonly IAsyncRepository<QuestionnairesDataSectionD> _questionnairesDataSectionD;
        private readonly IAsyncRepository<QuestionnairesDataSectionE> _questionnairesDataSectionE;
        private readonly IAsyncRepository<InputType> _inputTypeRepository;
        private readonly IAsyncRepository<Orientation> _orientationRepository;
        private readonly IAsyncRepository<LookupSet> _lookupRepository;
        // private readonly IAsyncRepository<TeacherFeedbackForm> _feedbackRepository;
        private readonly IAsyncRepository<QuestionnairesDataTeacherProfile> _profileRepository;
        private readonly IAsyncRepository<UserSessions> _usersessionsRepository;
        private readonly IAsyncRepository<Translation> _tranRepository;
        private readonly UserManager<EDIApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings EDIAppSettings { get; set; }
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
            UserManager<EDIApplicationUser> userManager,
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
            IAsyncRepository<FileImport> fileImportRepository,
            IAsyncRepository<QuestionnairesDataDemographic> questionnairesDataDemographic,
            IAsyncRepository<QuestionnairesDataSectionA> questionnairesDataSectionA,
            IAsyncRepository<QuestionnairesDataSectionB> questionnairesDataSectionB,
            IAsyncRepository<QuestionnairesDataSectionC> questionnairesDataSectionC,
            IAsyncRepository<QuestionnairesDataSectionD> questionnairesDataSectionD,
            IAsyncRepository<QuestionnairesDataSectionE> questionnairesDataSectionE,
            IAsyncRepository<InputType> inputTypeRepository,
            IAsyncRepository<Orientation> orientationRepository,
            IAsyncRepository<LookupSet> lookupRepository,
            IAsyncRepository<UserSessions> usersessionsRepository,
        //    IAsyncRepository<LookupSetOption> lookupSetOptionsRepository,
        // IAsyncRepository<TeacherFeedbackForm> feedbackRepository,
        //IAsyncRepository<TeacherParticipationForm> participationRepository,
            IAsyncRepository<QuestionnairesDataTeacherProfile> profileRepository,
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
        //  _lookupSetOptionRepository=lookupSetOptionsRepository;
            _teacherRepository = teacherRepository;
            _childRepository = childRepository;
            _questionnairesDataDemographic = questionnairesDataDemographic;
            _questionnairesDataSectionA = questionnairesDataSectionA;
            _questionnairesDataSectionB = questionnairesDataSectionB;
            _questionnairesDataSectionC = questionnairesDataSectionC;
            _questionnairesDataSectionD = questionnairesDataSectionD;
            _questionnairesDataSectionE = questionnairesDataSectionE;
            _inputTypeRepository = inputTypeRepository;
            _orientationRepository = orientationRepository;
            _usersessionsRepository = usersessionsRepository;
            _lookupRepository = lookupRepository;
            //_feedbackRepository = feedbackRepository;
            _profileRepository = profileRepository;
            _fileImportRepository = fileImportRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _dbContext = dbContext;
            _identityContext = identityContext;
            _emailSender = emailSender;
            _userSettings = UserSettings;
            _languageSettings = languageSettings;
            EDIAppSettings = settings.Value;
        }
        /*public List<LookupSetOption> GetLookupSetOptions(int LookupSetId)
        {
            return _lookupSetOptionRepository.GetByIdAsync(LookupSetId)
        }*/

        public async Task<IEnumerable<SelectListItem>> GetCountries()
        {
            
            WriteLogs("GetCountries started by:" + _userSettings.UserName, true);

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
                WriteLogs("GetCountries failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetProvinces(int countryid)
        {
            
            WriteLogs("GetProvinces started by:" + _userSettings.UserName, true);

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
                WriteLogs("GetProvinces failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetSites()
        {
            
            WriteLogs("GetSites started by:" + _userSettings.UserName, true);

            try
            {
                var sites = _siteRepository.ListAllSites().Where(t=>t.YearId == _userSettings.YearId).OrderBy(t => t.SiteNumber);

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
                WriteLogs("GetSites failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetCoordinators()
        {
            
            WriteLogs("GetCoordinators started by:" + _userSettings.UserName, true);

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
                WriteLogs("GetCoordinators failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetYears()
        {
            
            WriteLogs("GetYears started by:" + _userSettings.UserName, true);

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
                WriteLogs("GetYears failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetGenders()
        {
            
            WriteLogs("GetGenders started by:" + _userSettings.UserName, true);

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
                WriteLogs("GetGenders failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetSchools(int siteid)
        {
            
            WriteLogs("GetSchools started by:" + _userSettings.UserName, true);

            try
            {
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = "0", Text = "Choose One...", Selected = true }
                };

                if (siteid > 0)
                {
                    var filterSpecification = new SchoolFilterSpecification(siteid, _userSettings.YearId);
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
                WriteLogs("GetSchools failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetTeachers(int schoolid)
        {
            
            WriteLogs("GetTeachers started by:" + _userSettings.UserName, true);

            try
            {
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                }; 
                
                if (schoolid > 0)
                {
                    var filterSpecification = new TeacherFilterSpecification(schoolid, _userSettings.YearId);
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
                WriteLogs("GetTeachers failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<ErrorViewModel> UploadFileData(Syncfusion.Blazor.Inputs.UploadFiles file)
        {
            
            WriteLogs("UploadFileData started by:" + _userSettings.UserName, true);
            ErrorViewModel error = new ErrorViewModel();

            string errormessage = string.Empty;
            string message = string.Empty;
            List<string> messages = new List<string>();
            List<string> errormessages = new List<string>();
            
            var haserror = false;

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
                    string fileName = string.Format("Sites{0}.xlsx",DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                    string fullPath = Path.Combine(newPath, fileName);

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
                                    errormessages.Add("This Excel file is invalid");
                                    haserror = true;
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

                                    if (!ValidateExtension.IsEmailValid(_file.CoordinatorEmail))
                                    {
                                        errormessages.Add("Coordinator Email: " + _file.CoordinatorEmail + " is invalid at Row: " + (i + 1));
                                        haserror = true;
                                    }

                                    _file.SchoolName = row.Cells[3]?.CalculatedValue.Trim();
                                    _file.TeacherName = row.Cells[4]?.CalculatedValue.Trim();
                                    _file.TeacherEmail = row.Cells[5]?.CalculatedValue.Trim();

                                    if (!ValidateExtension.IsEmailValid(_file.TeacherEmail))
                                    {
                                        errormessages.Add("Teacher Email: " + _file.TeacherEmail + " is invalid at Row: " + (i + 1));
                                        haserror = true;
                                    }

                                    _file.LocalId = row.Cells[6]?.CalculatedValue.Trim();
                                    var gender = row.Cells[7]?.CalculatedValue.Trim();
                                    // get the lookupset for this year
                                   // var tempGenders = _dbContext.LookupSets.Where(p => p.YearId == _userSettings.YearId && p.LookupName == "ChildGender").Include(c => c.LookupSetOptions).FirstOrDefault();

                                    if (string.IsNullOrEmpty(gender))
                                    {
                                        //_file.GenderId = null;
                                        //_file.GenderId = tempGenders.LookupSetOptions.Where(p => p.YearId == _userSettings.YearId && p.English == "Other").FirstOrDefault().Value;
                                        _file.GenderId = _dbContext.Genders.Where(p => p.YearId == _userSettings.YearId && p.English == "Other").FirstOrDefault().Id;
                                    }
                                    else
                                    {
                                        //_file.GenderId = (gender == "M" ? (int)Genders.Male : (int)Genders.Female);
                                        //_file.GenderId = (gender == "M" ? dbContext.Gen.Where(p => p.Id == ppl.CountryID.Value).FirstOrDefault() : (int)Genders.Female);                                        
                                        // Use the code to ensure the values are consistent year over year
                                        

                                        if (gender == "M")
                                        {
                                            _file.GenderId = _dbContext.Genders.Where(p => p.YearId == _userSettings.YearId && p.English == "Male").FirstOrDefault().Id;                                            
                                            //_file.GenderId = tempGenders.LookupSetOptions.Where(p => p.YearId == _userSettings.YearId && p.English == "Male").FirstOrDefault().Value;
                                        }
                                        else if (gender == "F")
                                        {
                                            _file.GenderId = _dbContext.Genders.Where(p => p.YearId == _userSettings.YearId && p.English == "Female").FirstOrDefault().Id;
                                            //_file.GenderId = tempGenders.LookupSetOptions.Where(p => p.YearId == _userSettings.YearId && p.English == "Female").FirstOrDefault().Value;
                                        }
                                        else
                                        {
                                            _file.GenderId = _dbContext.Genders.Where(p => p.YearId == _userSettings.YearId && p.English == "Other").FirstOrDefault().Id;
                                            //_file.GenderId = tempGenders.LookupSetOptions.Where(p => p.YearId == _userSettings.YearId && p.English == "Other").FirstOrDefault().Value;
                                        }
                                    }


                                    var dob = row.Cells[8]?.CalculatedValue.Trim();

                                    if (string.IsNullOrEmpty(dob))
                                    {
                                        _file.ChildDob = null;
                                    }
                                    else
                                    {
                                        if (DateTime.TryParse(dob, out DateTime newvalue))
                                        {
                                            _file.ChildDob = newvalue;
                                        }
                                        else
                                        {
                                            errormessages.Add("Child Dob: " + dob + " is invalid at Row: " + (i+1));
                                            haserror = true;
                                        }
                                    }

                                    _file.ChildPostalCode = row.Cells[9]?.CalculatedValue.Trim();
                                    _file.ChildEdiid = row.Cells[10]?.CalculatedValue.Trim();

                                    _file.FileImportStatusId = (int)Enumerations.FileImportStatus.Imported;

                                    _file.ModifiedDate = DateTime.Now;
                                    _file.ModifiedBy = _userSettings.UserName;

                                    _file.CreatedDate = DateTime.Now;
                                    _file.CreatedBy = _userSettings.UserName;

                                    if(!haserror)
                                    {
                                        await _fileRepository.AddAsync(_file);

                                        error.message = "file has been imported successfully.";
                                    }
                                }
                            }
                        }

                        if (!haserror)
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
                    errormessages.Add("The file is empty!.");
                    haserror = true;
                }

                error.messages = messages;
                error.errormessages = errormessages;
                return error;
            }
            catch (Exception ex)
            {
                WriteLogs("UploadFileData failed:" + ex.Message, false);

                errormessage = "File imports failed. Please check the log file for more information.";

                errormessages.Add("ProcessFileData failed:" + ex.Message);
                error.message = message;
                error.errormessage = errormessage;
                error.errormessages = errormessages;
                return error;
            }
        }

        public async Task<ErrorViewModel> ProcessFileData()
        {
            
            WriteLogs("UploadFileData started by:" + _userSettings.UserName, true);
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
                    int fileimportstatusid = (int)Enumerations.FileImportStatus.Imported;

                    //var processstatusid = servicecontext.FileImportStatuses.Where(p => p.English == "Processed").First().Id;

                    var totalcoordinators = 0;
                    var totalsites = 0;
                    var totalschools = 0;
                    var totalteachers = 0;
                    var totalstudents = 0;

                    var password = string.Empty;

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
                            password = data.ChildEdiid.Substring(4, 8);

                            ///<summary>process year
                            ///</summary>
                            string subyear = data.ChildEdiid.Substring(0, 2);
                            short numsubyear = short.Parse(subyear);

                            //string currentyear = DateTime.Now.Year.ToString().Substring(2, 2);
                            //short numcurrentyear = short.Parse(currentyear);

                            var ediyear = short.Parse("20" + subyear);

                            //if (numsubyear > numcurrentyear)
                            //    ediyear = short.Parse("19" + subyear);

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
                                    var coordinator = servicecontext.Coordinators.Where(p => p.CoordinatorName == data.CoordinatorName && p.Email == data.CoordinatorEmail && p.YearId == yearid).FirstOrDefault();

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

                                                var newuser = new EDIApplicationUser
                                                {
                                                    UserName = data.CoordinatorEmail,
                                                    Email = data.CoordinatorEmail,
                                                    FirstName = firstname,
                                                    LastName = lastname
                                                };
                                                var result = await _userManager.CreateAsync(newuser, "EDI&"+lastname+"26");

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

                            var provinceid = 0;
                            var provincename = string.Empty;

                            var provinceedicodestring = data.ChildEdiid.Substring(2, 2);
                            var provinceedicode = int.Parse(provinceedicodestring);
                            var countryid = servicecontext.Provinces.Where(p => p.EDICode == provinceedicode && p.YearId == yearid).FirstOrDefault().CountryID;
                            provinceid = servicecontext.Provinces.Where(p => p.EDICode == provinceedicode && p.YearId == yearid).FirstOrDefault().Id;
                            provincename = servicecontext.Provinces.Where(p => p.EDICode == provinceedicode && p.YearId == yearid).FirstOrDefault().English.Replace(" ", "");

                            var predicateTeacher = "p => p." + provincename + ".Value && p.YearId == " + yearid + " && p.QuestionnaireName == \"Teacher Feedback\"";

                            var questionnaireTeacher = _dbContext.Questionnaires.Where(predicateTeacher).FirstOrDefault();

                            if (questionnaireTeacher == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Teacher Feedback\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            var predicate = "p => p." + provincename + " == true && p.YearId == " + yearid + " && p.QuestionnaireName == \"Demographics\"";

                            var questionnaire = _dbContext.Questionnaires.Where(predicate).FirstOrDefault();

                            var predicateA = "p => p." + provincename + " == true && p.YearId == " + yearid + " && p.QuestionnaireName == \"Section A\"";

                            var questionnaireA = _dbContext.Questionnaires.Where(predicateA).FirstOrDefault();

                            var predicateB = "p => p." + provincename + " == true && p.YearId == " + yearid + " && p.QuestionnaireName == \"Section B\"";

                            var questionnaireB = _dbContext.Questionnaires.Where(predicateB).FirstOrDefault();

                            var predicateC = "p => p." + provincename + " == true && p.YearId == " + yearid + " && p.QuestionnaireName == \"Section C\"";

                            var questionnaireC = _dbContext.Questionnaires.Where(predicateC).FirstOrDefault();

                            var predicateD = "p => p." + provincename + " == true && p.YearId == " + yearid + " && p.QuestionnaireName == \"Section D\"";

                            var questionnaireD = _dbContext.Questionnaires.Where(predicateD).FirstOrDefault();

                            var predicateE = "p => p." + provincename + " == true && p.YearId == " + yearid + " && p.QuestionnaireName == \"Section E\"";

                            var questionnaireE = _dbContext.Questionnaires.Where(predicateE).FirstOrDefault();

                            if (questionnaire == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Demographics\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            if (questionnaireA == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Section A\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            if (questionnaireB == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Section B\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            if (questionnaireC == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Section C\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            if (questionnaireD == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Section D\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            if (questionnaireE == null)
                            {
                                errormessages.Add("FileImports data " + data.Id + ": Questionnaire is invalid not associated to the year - " + ediyear + " with Questionnaire Name == \"Section E\" ");
                                haserror = true;
                                fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidQuestionnaire;
                            }

                            if(!haserror)
                            {
                                ///<summary>process site
                                ///</summary>
                                int siteid = 0;
                                if (!string.IsNullOrEmpty(data.SiteName))
                                {
                                    if (coordinatorid > 0)
                                    {
                                        string sitenumber = data.ChildEdiid.Substring(4, 3);

                                        var site = servicecontext.Sites.Where(p => p.SiteNumber == sitenumber && p.SiteName == data.SiteName && p.YearId == yearid).FirstOrDefault();

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

                                        var school = servicecontext.Schools.Where(p => p.SiteId == siteid && p.SchoolNumber == schoolnumber && p.SchoolName == data.SchoolName && p.YearId == yearid).FirstOrDefault();

                                        if (school == null)
                                        {
                                            try
                                            {
                                                var _school = new School();

                                                _school.SchoolNumber = schoolnumber;
                                                _school.SchoolName = data.SchoolName;


                                                if (provinceid == 0)
                                                {
                                                    errormessages.Add("FileImports data " + data.Id + ": Province is required.");
                                                    fileimportstatusid = (int)Enumerations.FileImportStatus.InvalidProvince;
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
                                            provinceid = school.ProvinceId;
                                            provincename = servicecontext.Provinces.Where(p => p.Id == provinceid).FirstOrDefault().English.Replace(" ", "");
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
                                            var teacher = servicecontext.Teachers.Where(p => p.TeacherName == data.TeacherName && p.Email == data.TeacherEmail && p.YearId == yearid).FirstOrDefault();

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

                                                        var newuser = new EDIApplicationUser();
                                                        newuser.UserName = Guid.NewGuid().ToString();
                                                        var result = await _userManager.CreateAsync(newuser, password);

                                                        var role = _identityContext.Roles.Where(p => p.Name == "Teacher").FirstOrDefault();

                                                        await _userManager.AddToRoleAsync(newuser, role.Name);

                                                        var oneuser = _identityContext.Users.Where(p => p.Id == newuser.Id).FirstOrDefault();
                                                        oneuser.UserName = data.TeacherEmail;
                                                        oneuser.Email = data.TeacherEmail;
                                                        oneuser.FirstName = firstname;
                                                        oneuser.LastName = lastname;
                                                        oneuser.NormalizedUserName = data.TeacherEmail.ToUpper();
                                                        oneuser.NormalizedEmail = data.TeacherEmail.ToUpper();

                                                        await _userManager.UpdateAsync(oneuser);

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
                                                    var teacherstatus = _dbContext.TeacherStatuses.Where(p => p.English == "New").FirstOrDefault();
                                                    var _teacher = new Teacher();

                                                    _teacher.UserId = userid;
                                                    _teacher.TeacherNumber = teachernumber;
                                                    _teacher.TeacherName = data.TeacherName;
                                                    _teacher.Email = data.TeacherEmail;
                                                    _teacher.SchoolId = schoolid;
                                                    _teacher.YearId = yearid;
                                                    _teacher.TeacherStatusId = teacherstatus.Id;
                                                    _teacher.CreatedDate = DateTime.Now;
                                                    _teacher.CreatedBy = _userSettings.UserName;
                                                    _teacher.ModifiedDate = DateTime.Now;
                                                    _teacher.ModifiedBy = _userSettings.UserName;

                                                    await _teacherRepository.AddAsync(_teacher);
                                                    teacherid = _teacher.Id;
                                                    totalteachers++;

                                                    var teacherprofile = _dbContext.QuestionnairesDataTeacherProfiles.Where(p => p.TeacherId == _teacher.Id && p.YearId == yearid).FirstOrDefault();

                                                    if (teacherprofile == null)
                                                    {
                                                        var _QuestionnairesDataTeacherProfile = new QuestionnairesDataTeacherProfile();
                                                        _QuestionnairesDataTeacherProfile.TeacherId = teacherid;
                                                        _QuestionnairesDataTeacherProfile.YearId = yearid;
                                                        _QuestionnairesDataTeacherProfile.QuestionnaireId = questionnaireTeacher.Id;
                                                        _QuestionnairesDataTeacherProfile.CreatedDate = DateTime.Now;
                                                        _QuestionnairesDataTeacherProfile.CreatedBy = _userSettings.UserName;
                                                        _QuestionnairesDataTeacherProfile.ModifiedDate = DateTime.Now;
                                                        _QuestionnairesDataTeacherProfile.ModifiedBy = _userSettings.UserName;

                                                        await _profileRepository.AddAsync(_QuestionnairesDataTeacherProfile);
                                                    }
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

                                                var onepassword = GeneratePassword(teacherid);

                                                var _account = await _accountRepository.GetByIdAsync(teacher.UserId);

                                                var newPassword = _userManager.PasswordHasher.HashPassword(_account, onepassword);
                                                _account.PasswordHash = newPassword;

                                                await _userManager.UpdateAsync(_account);
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
                                        //var child = servicecontext.Children.Where(p => p.LocalId == data.LocalId && p.Ediid == data.ChildEdiid && p.YearId == yearid).FirstOrDefault();
                                        var child = servicecontext.Children.Where(p => p.Ediid == data.ChildEdiid && p.YearId == yearid).FirstOrDefault();
                                        //var tempGenderId = servicecontext.Genders.Where(g => g.YearId == yearid && g.Code == data.GenderId.ToString()).FirstOrDefault().Id;

                                        if (child == null)
                                        {
                                            try
                                            {
                                                string childnumber = data.ChildEdiid.Substring(13, 2);
                                                var _child = new Child();

                                                var childstatus = _dbContext.ChildStatuses.Where(p => p.English == "New").FirstOrDefault();

                                                _child.Ediid = data.ChildEdiid;
                                                _child.LocalId = data.LocalId;
                                                _child.ChildNumber = childnumber;
                                                _child.YearId = yearid;
                                                _child.TeacherId = teacherid;
                                                _child.GenderId = data.GenderId;
                                                _child.Dob = data.ChildDob;
                                                _child.PostalCode = data.ChildPostalCode;
                                                _child.ChildStatusId = childstatus.Id;
                                                _child.CreatedDate = DateTime.Now;
                                                _child.CreatedBy = _userSettings.UserName;
                                                _child.ModifiedDate = DateTime.Now;
                                                _child.ModifiedBy = _userSettings.UserName;

                                                await _childRepository.AddAsync(_child);

                                                childid = _child.Id;
                                                totalstudents++;

                                                // be sure child has been created and has an id - then create questionnaires
                                                if (childid > 0)
                                                {
                                                    var demo = _dbContext.QuestionnairesDataDemographics.Where(p => p.ChildId == childid && p.YearId == yearid).FirstOrDefault();
                                                    var seca = _dbContext.QuestionnairesDataSectionAs.Where(p => p.ChildId == childid && p.YearId == yearid).FirstOrDefault();
                                                    var secb = _dbContext.QuestionnairesDataSectionBs.Where(p => p.ChildId == childid && p.YearId == yearid).FirstOrDefault();
                                                    var secc = _dbContext.QuestionnairesDataSectionCs.Where(p => p.ChildId == childid && p.YearId == yearid).FirstOrDefault();
                                                    var secd = _dbContext.QuestionnairesDataSectionDs.Where(p => p.ChildId == childid && p.YearId == yearid).FirstOrDefault();
                                                    var sece = _dbContext.QuestionnairesDataSectionEs.Where(p => p.ChildId == childid && p.YearId == yearid).FirstOrDefault();

                                                    if (demo == null)
                                                    {
                                                        var _demographics = new QuestionnairesDataDemographic();

                                                        _demographics.ChildId = childid;
                                                        _demographics.GenderId = data.GenderId;
                                                        _demographics.Dob = data.ChildDob;
                                                        _demographics.PostalCode = data.ChildPostalCode;
                                                        _demographics.QuestionnaireId = questionnaire.Id;
                                                        _demographics.YearId = yearid;
                                                        _demographics.CreatedDate = DateTime.Now;
                                                        _demographics.CreatedBy = _userSettings.UserName;
                                                        _demographics.ModifiedDate = DateTime.Now;
                                                        _demographics.ModifiedBy = _userSettings.UserName;

                                                        await _questionnairesDataDemographic.AddAsync(_demographics);
                                                    }
                                                    else
                                                    {
                                                        errormessages.Add("FileImports data " + data.Id + ": has a duplicate Child with child id: " + childid + " inside QuestionnairesDataDemographic table");
                                                        haserror = true;
                                                        fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                                    }

                                                    if (seca == null)
                                                    {
                                                        var _sectionA = new QuestionnairesDataSectionA();

                                                        _sectionA.ChildId = childid;
                                                        _sectionA.QuestionnaireId = questionnaireA.Id;
                                                        _sectionA.YearId = yearid;
                                                        _sectionA.CreatedDate = DateTime.Now;
                                                        _sectionA.CreatedBy = _userSettings.UserName;
                                                        _sectionA.ModifiedDate = DateTime.Now;
                                                        _sectionA.ModifiedBy = _userSettings.UserName;

                                                        await _questionnairesDataSectionA.AddAsync(_sectionA);
                                                    }
                                                    else
                                                    {
                                                        errormessages.Add("FileImports data " + data.Id + ": has a duplicate Child with child id: " + childid + " inside QuestionnairesDataSectionA table");
                                                        haserror = true;
                                                        fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                                    }

                                                    if (secb == null)
                                                    {
                                                        var _sectionB = new QuestionnairesDataSectionB();

                                                        _sectionB.ChildId = childid;
                                                        _sectionB.QuestionnaireId = questionnaireB.Id;
                                                        _sectionB.YearId = yearid;
                                                        _sectionB.CreatedDate = DateTime.Now;
                                                        _sectionB.CreatedBy = _userSettings.UserName;
                                                        _sectionB.ModifiedDate = DateTime.Now;
                                                        _sectionB.ModifiedBy = _userSettings.UserName;

                                                        await _questionnairesDataSectionB.AddAsync(_sectionB);
                                                    }
                                                    else
                                                    {
                                                        errormessages.Add("FileImports data " + data.Id + ": has a duplicate Child with child id: " + childid + " inside QuestionnairesDataSectionB table");
                                                        haserror = true;
                                                        fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                                    }

                                                    if (secc == null)
                                                    {
                                                        var _sectionC = new QuestionnairesDataSectionC();

                                                        _sectionC.ChildId = childid;
                                                        _sectionC.QuestionnaireId = questionnaireC.Id;
                                                        _sectionC.YearId = yearid;
                                                        _sectionC.CreatedDate = DateTime.Now;
                                                        _sectionC.CreatedBy = _userSettings.UserName;
                                                        _sectionC.ModifiedDate = DateTime.Now;
                                                        _sectionC.ModifiedBy = _userSettings.UserName;

                                                        await _questionnairesDataSectionC.AddAsync(_sectionC);
                                                    }
                                                    else
                                                    {
                                                        errormessages.Add("FileImports data " + data.Id + ": has a duplicate Child with child id: " + childid + " inside QuestionnairesDataSectionC table");
                                                        haserror = true;
                                                        fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                                    }

                                                    if (secd == null)
                                                    {
                                                        var _sectionD = new QuestionnairesDataSectionD();

                                                        _sectionD.ChildId = childid;
                                                        _sectionD.QuestionnaireId = questionnaireD.Id;
                                                        _sectionD.YearId = yearid;
                                                        _sectionD.CreatedDate = DateTime.Now;
                                                        _sectionD.CreatedBy = _userSettings.UserName;
                                                        _sectionD.ModifiedDate = DateTime.Now;
                                                        _sectionD.ModifiedBy = _userSettings.UserName;

                                                        await _questionnairesDataSectionD.AddAsync(_sectionD);
                                                    }
                                                    else
                                                    {
                                                        errormessages.Add("FileImports data " + data.Id + ": has a duplicate Child with child id: " + childid + " inside QuestionnairesDataSectionD table");
                                                        haserror = true;
                                                        fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                                    }

                                                    if (sece == null)
                                                    {
                                                        var _sectionE = new QuestionnairesDataSectionE();

                                                        _sectionE.ChildId = childid;
                                                        _sectionE.QuestionnaireId = questionnaireE.Id;
                                                        _sectionE.YearId = yearid;
                                                        _sectionE.CreatedDate = DateTime.Now;
                                                        _sectionE.CreatedDate = DateTime.Now;
                                                        _sectionE.CreatedBy = _userSettings.UserName;
                                                        _sectionE.ModifiedDate = DateTime.Now;
                                                        _sectionE.ModifiedBy = _userSettings.UserName;

                                                        await _questionnairesDataSectionE.AddAsync(_sectionE);
                                                    }
                                                    else
                                                    {
                                                        errormessages.Add("FileImports data " + data.Id + ": has a duplicate Child with child id: " + childid + " inside QuestionnairesDataSectionE table");
                                                        haserror = true;
                                                        fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                errormessages.Add("FileImports data " + data.Id + ": Create a student error: " + ex.Message);
                                                haserror = true;
                                            }                                           
                                        }
                                        else
                                        {
                                            // get the existing child ID - nothing needs to be done beyond this as the record already exists
                                            childid = child.Id;
                                            fileimportstatusid = (int)Enumerations.FileImportStatus.Duplicate;
                                            errormessages.Add(data.ChildEdiid + " Already Exists");
                                            haserror = true;
                                        }                                        
                                    }
                                }
                                else
                                {
                                    errormessages.Add("FileImports data " + data.Id + ": Local Id is required.");
                                    haserror = true;
                                }
                            }
                        }

                        if (!haserror)
                        {
                            fileimportstatusid = (int)Enumerations.FileImportStatus.Processed;
                        }

                        data.FileImportStatusId = fileimportstatusid;
                        data.ModifiedDate = DateTime.Now;
                        data.ModifiedBy = _userSettings.UserName;

                        await _fileRepository.UpdateAsync(data);
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
                WriteLogs("ProcessFileData failed:" + ex.Message, false);

                errormessage = "Processing data failed. Please check the log file for more information.";
                errormessages.Add("ProcessFileData failed:" + ex.Message);
                error.message = message;
                error.errormessage = errormessage;
                error.errormessages = errormessages;
                return error;
            }
        }

        public async Task<ErrorViewModel> UploadTranslationData(Syncfusion.Blazor.Inputs.UploadFiles file)
        {
            WriteLogs("UploadTranslationData started by:" + _userSettings.UserName, true);
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
                    string fileName = string.Format("Translations{0}.xlsx", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                    string fullPath = Path.Combine(newPath, fileName);

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
                WriteLogs("UploadTranslationData failed:" + ex.Message, false);

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
                    var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
                    optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
                    using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
                    {
                        var translate = servicecontext.Translations.Where(e => e.English == english).FirstOrDefault();
                        if (translate == null || string.IsNullOrEmpty(translate.French))
                            return english;
                        else
                            return translate.French;
                    }
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

        public async Task<string> SendTeacherPassword(Teacher teacher)
        {
            WriteLogs("SendPassword started by:" + _userSettings.UserName, true);
            string message = string.Empty;

            try
            {
                var password = GeneratePassword(teacher.Id);

                var _account = _identityContext.Users.Where(p => p.Id == teacher.UserId).FirstOrDefault();

                var newPassword = _userManager.PasswordHasher.HashPassword(_account, password);
                _account.PasswordHash = newPassword;
                _account.SecurityStamp = Guid.NewGuid().ToString();
                _account.NormalizedEmail = _account.Email.ToUpper();
                _account.NormalizedUserName = _account.UserName.ToUpper();

                await _identityContext.SaveChangesAsync();

                EmailModel email = new EmailModel();

                email.Subject = "Reset Password";
                email.From = EDIAppSettings.EmailFrom;
                email.To = teacher.Email;

                var user = _identityContext.Users.Where(p => p.Id == teacher.UserId).FirstOrDefault();

                string htmlString = string.Format(@"<html>
                      <body>
                      <p>Dear {0},</p>
                      <p>This email is to confirm that the password for your account has been reset: {1}</p>", teacher.TeacherName, password);
                string htmlString2 = @"<p>Please let us know if you have any questions or concerns.</p> 
                      <p>Thank you!<br><br>EDI<br />webmaster@e-edi.ca</p>
                      </body>
                      </html>";
                string htmlString4 = htmlString + htmlString2;

                email.Body = htmlString4;

                message = await SendEmail(email);

                return message;
            }
            catch (Exception ex)
            {
                WriteLogs("SendPassword failed:" + ex.Message, false);
                message = "Failed: " + ex.Message;
                return message;
            }
        }

        public async Task<string> SendEmail(EmailModel EmailModel)
        {
            string message = string.Empty;

            if(string.IsNullOrEmpty(EmailModel.To))
                EmailModel.To = EDIAppSettings.EmailTo;

            message = await _emailSender.SendEmailAsync(EmailModel);

            return message;
        }

        public async void SendException(string exceptionmsg, string innermsg, string filename, string methodname)
        {
            var errorslog = await Task.FromResult(_dbContext.SystemConfigurations.Where(s => s.FieldName == "Errors-Log").FirstOrDefault());

            if(bool.TryParse(errorslog.FieldValue, out bool value))
            {
                WriteLogs(string.Format("{0}:{1}:{2}:{3}", filename, methodname, exceptionmsg, innermsg), false);
            }

            var errorsemail = await Task.FromResult(_dbContext.SystemConfigurations.Where(s => s.FieldName == "Errors-Email").FirstOrDefault());

            if (bool.TryParse(errorsemail.FieldValue, out bool value2))
            {
                var EmailModel = new EmailModel();

                EmailModel.Subject = "System Exception";

                EmailModel.From = EDIAppSettings.EmailFrom;
                EmailModel.To = EDIAppSettings.EmailTo;
                //EmailModel.To = "Bryan.Deng@phri.ca";

                string htmlString = "<html><body><p>";
                string htmlString2 = "File: " + filename + "<br />";
                string htmlString3 = "Method: " + methodname + "<br />";
                string htmlString4 = exceptionmsg + "<br />";
                string htmlString5 = Regex.Replace(innermsg, "\r\\D\n?|\n\\D\r?", "</p><p>");
                string htmlString6 = "</p></body></html>";

                string htmlString7 = htmlString + htmlString2 + htmlString3 + htmlString4 + htmlString5 + htmlString6;

                EmailModel.Body = htmlString7;
                try
                {
                    await _emailSender.SendEmailAsync(EmailModel);
                }
                catch (Exception ex)
                {
                    WriteLogs("SendException failed:" + ex.Message, false);
                }

            }
        }

        public string GetConfigText(QuestionnairesConfiguration config)
        {
            return GetLanguageText(config.English, config.French);
        }

        public string GetHelpText(QuestionnairesConfiguration config)
        {
            return GetLanguageText(config.HelpTextEnglish, config.HelpTextFrench);
        }

        public string GetOptionText(LookupSetOption option)
        {
            return GetLanguageText(option.English, option.French);
        }

        public string GetQuestionnaireText(Questionnaire q)
        {
            return GetLanguageText(q.English, q.French);
        }
        private string GetLanguageText(string English, string French)
        {
            string LanguageText = "";

            if (_userSettings.Language.Equals("English"))
                LanguageText = English;
            else
                LanguageText = French;

            return LanguageText;
        }

        public IEnumerable<SelectListItem> GetInpuTypes()
        {

            WriteLogs("GetInpuTypes started by:" + _userSettings.UserName, true);

            try
            {
                var inputtypes = _inputTypeRepository.ListAllInputTypes().OrderBy(t => t.English);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var inputtype in inputtypes)
                {
                    if (inputtype.YearId == _userSettings.YearId)
                        items.Add(new SelectListItem() { Value = inputtype.Id.ToString(), Text = inputtype.English });
                }


                return items;
            }
            catch (Exception ex)
            {
                WriteLogs("GetInpuTypes failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public IEnumerable<SelectListItem> GetOrientations()
        {
            WriteLogs("GetOrientations started by:" + _userSettings.UserName, true);

            try
            {
                var orientations = _orientationRepository.ListAllOrientations().OrderBy(t => t.English);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var orientation in orientations)
                {
                    if (orientation.YearId == _userSettings.YearId)
                        items.Add(new SelectListItem() { Value = orientation.Id.ToString(), Text = orientation.English });
                }

                return items;
            }
            catch (Exception ex)
            {
                WriteLogs("GetOrientations failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public IEnumerable<SelectListItem> GetLookups()
        {
            WriteLogs("GetLookups started by:" + _userSettings.UserName, true);

            try
            {
                var lookups = _lookupRepository.ListAllLookups().OrderBy(t => t.LookupName);

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var lookup in lookups)
                {
                    if (lookup.YearId == _userSettings.YearId)
                        items.Add(new SelectListItem() { Value = lookup.Id.ToString(), Text = lookup.LookupName });
                }

                return items;
            }
            catch (Exception ex)
            {
                WriteLogs("GetLookups failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public IEnumerable<SelectListItem> GetEntities()
        {

            WriteLogs("GetEntities started by:" + _userSettings.UserName, true);

            try
            {
                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true },
                    new SelectListItem() { Value = "01", Text = "Demographics" },
                    new SelectListItem() { Value = "02", Text = "Section A" },
                    new SelectListItem() { Value = "03", Text = "Section B" },
                    new SelectListItem() { Value = "04", Text = "Section C" },
                    new SelectListItem() { Value = "05", Text = "Section D" },
                    new SelectListItem() { Value = "06", Text = "Section E" },
                    new SelectListItem() { Value = "07", Text = "Teacher FeedBack" }
                };
                return items;
            }
            catch (Exception ex)
            {
                WriteLogs("GetEntities failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task<IEnumerable<SelectListItem>> GetFields(string entityname)
        {

            WriteLogs("GetFields started by:" + _userSettings.UserName, true);

            try
            {
                var fields = await Task.FromResult(_dbContext.QuestionnairesConfigurations.Where(t => t.YearId == _userSettings.YearId && t.EntityName == entityname && !string.IsNullOrEmpty(t.EntityField)).OrderBy(p => p.EntityField).ToList());

                switch (_userSettings.Province)
                {
                    case "Alberta":
                        fields = fields.Where(p => p.Alberta == true).ToList();
                        break;
                    case "BritishColumbia":
                        fields = fields.Where(p => p.BritishColumbia == true).ToList();
                        break;
                    case "Manitoba":
                        fields = fields.Where(p => p.Manitoba == true).ToList();
                        break;
                    case "NewBrunswick":
                        fields = fields.Where(p => p.NewBrunswick == true).ToList();
                        break;
                    case "NewfoundlandandLabrador":
                        fields = fields.Where(p => p.NewfoundlandandLabrador == true).ToList();
                        break;
                    case "NovaScotia":
                        fields = fields.Where(p => p.NovaScotia == true).ToList();
                        break;
                    case "Nunavut":
                        fields = fields.Where(p => p.Nunavut == true).ToList();
                        break;
                    case "Ontario":
                        fields = fields.Where(p => p.Ontario == true).ToList();
                        break;
                    case "PrinceEdwardIsland":
                        fields = fields.Where(p => p.PrinceEdwardIsland == true).ToList();
                        break;
                    case "Quebec":
                        fields = fields.Where(p => p.Quebec == true).ToList();
                        break;
                    case "Saskatchewan":
                        fields = fields.Where(p => p.Saskatchewan == true).ToList();
                        break;
                    case "YukonTerritory":
                        fields = fields.Where(p => p.YukonTerritory == true).ToList();
                        break;
                    case "NorthwestTerritories":
                        fields = fields.Where(p => p.NorthwestTerritories == true).ToList();
                        break;
                    case "NewYork":
                        fields = fields.Where(p => p.NewYork == true).ToList();
                        break;
                }

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
                };

                foreach (var field in fields)
                {
                    items.Add(new SelectListItem() { Value = field.Id.ToString(), Text = field.EntityField });
                }

                return items;
            }
            catch (Exception ex)
            {
                WriteLogs("GetFields failed:" + ex.Message, false);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public async Task SaveUserSessions(string fieldname, string fieldvalue, string userid)
        {
            WriteLogs("SaveUserSessions started by:" + _userSettings.UserName, true);

            try
            {
                var usersession = await Task.FromResult(_dbContext.UserSessions.Where(s => s.FieldName == fieldname && s.UserID == userid).FirstOrDefault());

                if(usersession != null)
                {
                    usersession.FieldValue = fieldvalue;
                    await _usersessionsRepository.UpdateAsync(usersession);
                }
                else
                {
                    var session = new UserSessions();
                    session.UserID = userid;
                    session.FieldName = fieldname;
                    session.FieldValue = fieldvalue;
                    session.CreatedDate = DateTime.Now;
                    session.CreatedBy = _userSettings.UserName;
                    session.ModifiedDate = DateTime.Now;
                    session.ModifiedBy = _userSettings.UserName;

                    await _usersessionsRepository.AddAsync(session);
                }
            }
            catch (Exception ex)
            {
                WriteLogs("SaveUserSessions failed:" + ex.Message, false);                
            }
        }

        public async Task DeleteUserSessions( string userid)
        {
            WriteLogs("DeleteUserSessions started by:" + _userSettings.UserName, true);

            try
            {
                var usersessions = await Task.FromResult(_dbContext.UserSessions.Where(s => s.UserID == userid).ToList());

                if (usersessions != null && usersessions.Count > 0)
                {
                    foreach(var session in usersessions)
                    {
                        await _usersessionsRepository.DeleteAsync(session);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLogs("DeleteUserSessions failed:" + ex.Message, false);
            }
        }

        public void InitializeUserSettings(string username)
        {
            var user1 = _identityContext.Users.Where(p => p.UserName == username).FirstOrDefault();
            var userrole = _identityContext.UserRoles.Where(p => p.UserId == user1.Id).FirstOrDefault();

            var role = _identityContext.Roles.Where(p => p.Id == userrole.RoleId).FirstOrDefault();

            var predicate = "FieldName==\"Year\"";
            var year = _dbContext.SystemConfigurations.Where(predicate).Single().FieldValue;
            predicate = "EDIYear == " + year;

            var province = _dbContext.Provinces.Where(p => p.Id == user1.ProvinceID).FirstOrDefault();
            //TODO check to see if ProvinceID is null - causes app to crash if null

            _userSettings.YearId = _dbContext.Years.Where(predicate).Single().Id;
            _userSettings.UserName = user1.UserName;
            _userSettings.IsAuthenticated = true;
            _userSettings.UserID = user1.Id;
            _userSettings.FirstName = user1.FirstName;
            _userSettings.LastName = user1.LastName;
            _userSettings.IsAdmin = false;
            _userSettings.IsCoordinator = false;
            _userSettings.IsTeacher = false;
            _userSettings.QuestionsCompleted = 0;
            _userSettings.QuestionsRequired = 0;
            _userSettings.QuestionsTotal = 0;            
            _userSettings.Language = user1.Language == null ? "English" : user1.Language;

            var hastestdata = _dbContext.UserSessions.Where(p => p.FieldName == "HasTestData" && p.UserID == user1.Id).FirstOrDefault();
            _userSettings.HasTestData = hastestdata != null ? bool.Parse(hastestdata.FieldValue) : false;

            if (role.Name == "Teacher")
            {
                var teacher = _dbContext.Teachers.Where(s => s.UserId == _userSettings.UserID && s.YearId == _userSettings.YearId)
                            .Include(s => s.School)
                            .ThenInclude(ts => ts.Province).FirstOrDefault();

                if (teacher != null)
                {
                    _userSettings.IsTeacher = true;
                    _userSettings.Province = teacher.School.Province.English.Replace(" ", "");
                    _userSettings.TeacherId = teacher.Id;
                }
            }
            else
            {
                if (role.Name == "Administrator")
                {
                    _userSettings.IsAdmin = true;
                    _userSettings.Province = province.English.Replace(" ", "");
                }
                else
                    _userSettings.IsCoordinator = true;
            }
        }

        private string GeneratePassword(int id)
        {
            var password = string.Empty;

            var teacher = _dbContext.Teachers.Where(p => p.Id == id).FirstOrDefault();

            var child = _dbContext.Children.Where(p => p.TeacherId == teacher.Id).FirstOrDefault();
            password = child.Ediid.Substring(4, 8);

            return password;
        }

        public async Task ResetPassword(int id)
        {
            var teacher = _dbContext.Teachers.Where(p => p.Id == id).FirstOrDefault();

            var password = GeneratePassword(id);

            var _account = await _accountRepository.GetByIdAsync(teacher.UserId);

            var newPassword = _userManager.PasswordHasher.HashPassword(_account, password);
            _account.PasswordHash = newPassword;

            await _userManager.UpdateAsync(_account);
        }

        public void WriteLogs(string message, bool isinfo)
        {
            if(isinfo)
            {
                if (EDIAppSettings.LogInformation)
                {
                    Log.Information(message);
                }
            }
            else
            {
                if (EDIAppSettings.LogError)
                {
                    Log.Error(message);
                }
            }
        }
        public async Task ClearQueue()
        {
            WriteLogs("ClearQueue started by:" + _userSettings.UserName, true);

            try
            {
                var queues = await Task.FromResult(_dbContext.FileImports.Where(s => s.FileImportStatusId != (int)Enumerations.FileImportStatus.Processed).ToList());

                if (queues != null && queues.Count > 0)
                {
                    foreach (var queueu in queues)
                    {
                        await _fileImportRepository.DeleteAsync(queueu);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLogs("ClearQueue failed:" + ex.Message, false);
            }
        }
        public async Task UpdatePercentComplete(int ChildId, byte IsTest)
        {
            try
            {
                //var id = new SqlParameter("id", 1);

                //var tmp = 1;
                //var tmp2 = 6;
                //var tmp3 = 0;

                await _dbContext.Database
                  .ExecuteSqlRawAsync($"EXECUTE UpdateChildPercentComplete {ChildId}, {IsTest}");
            }
            catch (Exception ex)
            {

            }

        }

        //public async Task<IEnumerable<SelectListItem>> GetReportTypes()
        //{

        //    WriteLogs("GetReportTypes started by:" + _userSettings.UserName, true);

        //    try
        //    {
        //        ////var sites = _siteRepository.ListAllSites().OrderBy(t => t.SiteNumber);

        //        //var items = new List<SelectListItem>
        //        //{
        //        //    new SelectListItem() { Value = null, Text = "Choose One...", Selected = true }
        //        //};

        //        //items.Add(new SelectListItem() { Value = "1", Text = "Students" });
        //        //items.Add(new SelectListItem() { Value = "2", Text = "Teachers" });
        //        //items.Add(new SelectListItem() { Value = "3", Text = "Schools" });
        //        //items.Add(new SelectListItem() { Value = "4", Text = "Sites" });
        //        SqlConnection conn = new SqlConnection(ConnectionStrings.ServiceConnection());
        //        conn.Open();
        //        {
        //            // create the command object
        //            SqlCommand sqlComm = new SqlCommand("[Reports].[GetChildrenBySite]", conn);

        //            // Add Parameters
        //            sqlComm.Parameters.AddWithValue("@SiteId", 1);

        //            sqlComm.CommandType = CommandType.StoredProcedure;

        //            SqlDataReader reader = sqlComm.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                var obj = SqlDataReaderToExpando(reader);
        //                ReportData.Add(obj);
        //            }

        //            reader.Close();
        //            conn.Close();
        //        }

        //        return items;
        //    }
        //    catch (Exception ex)
        //    {
        //        WriteLogs("GetReportTypes failed:" + ex.Message, false);

        //        var vm = new List<SelectListItem>();

        //        return vm;
        //    }
        //}
    }
}
