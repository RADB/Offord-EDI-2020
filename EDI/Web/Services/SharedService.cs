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

        public string GetContentRootFolder()
        {
            string folderName = "Upload";
            string webRootPath = _hostingEnvironment.ContentRootPath + @"\wwwroot";
            string newPath = Path.Combine(webRootPath, folderName);

            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            
            return newPath;
        }
            
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
                var genders = _genderRepository.ListAllGenders().Where(t => t.YearId == _userSettings.YearId).OrderBy(t => t.English);

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

                    var columnHeaders = new string[]
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
                                if ((cell == null || string.IsNullOrWhiteSpace(cell.CalculatedValue)) || cell.CalculatedValue.ToLower() != columnHeaders[j].Trim().ToLower())
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

        public string GeneratePassword(int id)
        {
            //TODO - with students moving the reset pwd needs to be smarter - could be the wrong ID
            var password = string.Empty;

            var teacher = _dbContext.Teachers.Where(p => p.Id == id && p.YearId == _userSettings.YearId).FirstOrDefault();

            var child = _dbContext.Children.Where(p => p.TeacherId == teacher.Id).FirstOrDefault();
            password = child.Ediid.Substring(4, 8);

            return password;
        }

        public async Task ResetPassword(int id)
        {
            var teacher = _dbContext.Teachers.Where(p => p.Id == id && p.YearId == _userSettings.YearId).FirstOrDefault();

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
