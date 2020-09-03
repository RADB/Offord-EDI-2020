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
using Syncfusion.XlsIO;

namespace EDI.Web.Services
{
    public class SharedService: ISharedService
    {
        private readonly ILogger<AccountService> _logger;
        private readonly IAsyncIdentityRepository _accountRepository;
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IAsyncRepository<Province> _provinceRepository;
        private readonly IAsyncRepository<FileImport> _fileRepository;
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
            IAsyncRepository<FileImport> fileRepository,
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
            _fileRepository = fileRepository;
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

        public async Task<ErrorViewModel> UploadFileData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file)
        {
            await LogUsername();
            Log.Information("UploadFileData started by:" + _username);
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
                        "School Province",
                        "Teacher Name",
                        "Teacher Email",
                        "Child's Local ID",
                        "Class_tm",
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
                                if (j > 12)
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

                            await _fileRepository.DeleteAllFileImports();
                            await _fileRepository.ReseedFileImports();

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

                                var province = row.Cells[4]?.CalculatedValue.Trim();
                                if (string.IsNullOrEmpty(province))
                                {
                                    _file.SchoolProvinceId = null;
                                }
                                else
                                {
                                    //if (currency == "CAD")
                                    //    currency = "CAD - Canadian dollar";

                                    //var currencyid = _dbContext.Currency.Where(p => p.Name == currency).Select(p => p.Id).FirstOrDefault();

                                    _file.SchoolProvinceId =int.Parse(province);
                                }
                                _file.TeacherName = row.Cells[5]?.CalculatedValue.Trim();
                                _file.TeacherEmail = row.Cells[6]?.CalculatedValue.Trim();
                                _file.LocalId = row.Cells[7]?.CalculatedValue.Trim();
                                var classtime = row.Cells[8]?.CalculatedValue.Trim();

                                if (string.IsNullOrEmpty(classtime))
                                {
                                    _file.ClassTime = null;
                                }
                                else
                                {
                                    _file.ClassTime = byte.Parse(classtime);
                                }
                                
                                var gender = row.Cells[9]?.CalculatedValue.Trim();

                                if (string.IsNullOrEmpty(gender))
                                {
                                    _file.GenderId = null;
                                }
                                else
                                {
                                    int genderid = 0;
                                    if(gender == "M")
                                    {
                                        genderid = _dbContext.Genders.Where(p => p.English == "Male").FirstOrDefault().Id;
                                    }
                                    else
                                    {
                                        genderid = _dbContext.Genders.Where(p => p.English == "Female").FirstOrDefault().Id;
                                    }

                                    _file.GenderId = genderid;
                                }


                                var dob = row.Cells[10]?.CalculatedValue.Trim();

                                if (string.IsNullOrEmpty(dob))
                                {
                                    _file.ChildDob = null;
                                }
                                else
                                {
                                    _file.ChildDob = DateTime.Parse(dob);
                                }

                                _file.ChildPostalCodeZip = row.Cells[11]?.CalculatedValue.Trim();
                                _file.ChildEdiid = row.Cells[12]?.CalculatedValue.Trim();


                                int statusid = 0;
                                statusid = _dbContext.FileImportStatuses.Where(p => p.English == "Imported").FirstOrDefault().Id;

                                _file.FileImportStatusId = statusid;

                                _file.ModifiedDate = DateTime.Now;
                                _file.ModifiedBy = _username;

                                _file.CreatedDate = DateTime.Now;
                                _file.CreatedBy = _username;

                                await _fileRepository.AddAsync(_file);

                                error.message = "file has been imported successfully.";
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
    }
}
