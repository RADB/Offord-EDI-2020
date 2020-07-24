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
using System.Globalization;
using Syncfusion.Pdf;
using Syncfusion.HtmlConverter;
using EDI.ApplicationCore.Models;
using BlazorInputFile;
using Syncfusion.XlsIO;

namespace EDI.Web.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly IAsyncRepository<CustomerAccess> _customeraccessRepository;
        private readonly IAsyncRepository<Customers> _customerRepository;
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IAsyncRepository<Province> _provinceRepository;
        private readonly IAsyncRepository<Currency> _currencyRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings POAppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private readonly ServiceContext _dbContext;
        private IHostEnvironment _hostingEnvironment;
        private readonly IEmailSender _emailSender;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }

        public CustomerService(
            ILoggerFactory loggerFactory,
            IAsyncRepository<CustomerAccess> customeraccessRepository,
            IAsyncRepository<Customers> customerRepository,
            IAsyncRepository<Country> countryRepository,
            IAsyncRepository<Province> provinceRepository,
            IAsyncRepository<Currency> currencyRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            IEmailSender emailSender,
            AuthenticationStateProvider authenticationStateProvider,
            ServiceContext dbContext,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<CustomerService>();
            _httpContextAccessor = httpContextAccessor;
            _customeraccessRepository = customeraccessRepository;
            _customerRepository = customerRepository;
            _countryRepository = countryRepository;
            _provinceRepository = provinceRepository;
            _currencyRepository = currencyRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            _dbContext = dbContext;
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

        public async Task DeleteCustomerAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteCustomerAsync started by:" + _username);

            try
            {
                var customer = await _customerRepository.GetByIdAsync(Id);

                Guard.Against.NullCustomer(Id, customer);

                await _customerRepository.DeleteAsync(customer);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteCustomerAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateCustomerAsync(CustomerItemViewModel customer)
        {
            await LogUsername();
            Log.Information("UpdateCustomerAsync started by:" + _username);

            try
            {
                var _customer = await _customerRepository.GetByIdAsync(customer.Id);

                if (!string.IsNullOrEmpty(customer.Email))
                {
                    if (!ValidateExtension.IsEmailValid(customer.Email))
                    {
                        Log.Error("Email: " + customer.Email + " is invalid.");
                        return;
                    }
                }

                Guard.Against.NullCustomer(customer.Id, _customer);

                _customer.Name = customer.Name;
                _customer.Email = customer.Email;
                _customer.Contact1 = customer.Contact1;
                _customer.Contact2 = customer.Contact2;
                _customer.Phone = customer.Phone;
                _customer.CurrencyID = customer.CurrencyID;
                _customer.BillingCountryID = customer.BillingCountryID;
                _customer.BillingProvinceID = customer.BillingProvinceID;
                _customer.BillingAddress1 = customer.BillingAddress1;
                _customer.BillingAddress2 = customer.BillingAddress2;
                _customer.BillingCity = customer.BillingCity;
                _customer.BillingPostal = customer.BillingPostal;
                _customer.HasShippingAddress = customer.HasShippingAddress;
                if(customer.HasShippingAddress.HasValue && customer.HasShippingAddress.Value)
                {
                    _customer.ShippingContact = customer.ShippingContact;
                    _customer.ShippingCountryID = customer.ShippingCountryID;
                    _customer.ShippingProvinceID = customer.ShippingProvinceID;
                    _customer.ShippingAddress1 = customer.ShippingAddress1;
                    _customer.ShippingAddress2 = customer.ShippingAddress2;
                    _customer.ShippingCity = customer.ShippingCity;
                    _customer.ShippingPostal = customer.ShippingPostal;
                    _customer.ShippingPhone = customer.ShippingPhone;
                    _customer.DeliveryInstructions = customer.DeliveryInstructions;
                }
                else
                {
                    _customer.ShippingContact = null;
                    _customer.ShippingCountryID = null;
                    _customer.ShippingProvinceID = null;
                    _customer.ShippingAddress1 = null;
                    _customer.ShippingAddress2 = null;
                    _customer.ShippingCity = null;
                    _customer.ShippingPostal = null;
                    _customer.ShippingPhone = null;
                    _customer.DeliveryInstructions = null;
                }                
                _customer.AccountNumber = customer.AccountNumber;
                _customer.Fax = customer.Fax;
                _customer.Mobile = customer.Mobile;
                _customer.TollFree = customer.TollFree;
                _customer.Website = customer.Website;
                _customer.InternalNotes = customer.InternalNotes;
                _customer.ModifiedDate = DateTime.Now;
                _customer.ModifiedBy = _username;

                await _customerRepository.UpdateAsync(_customer);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateCustomerAsync failed:" + ex.Message);
            }
        }

        public async Task CreateCustomerAsync(CustomerItemViewModel customer)
        {
            await LogUsername();
            Log.Information("CreateCustomerAsync started by:" + _username);

            try
            {
                var _customer = new Customers();

                if (!string.IsNullOrEmpty(customer.Email))
                {
                    if (!ValidateExtension.IsEmailValid(customer.Email))
                    {
                        Log.Error("Email: " + customer.Email + " is invalid.");
                        return;
                    }
                }

                _customer.Name = customer.Name;
                _customer.Email = customer.Email;
                _customer.Contact1 = customer.Contact1;
                _customer.Contact2 = customer.Contact2;
                _customer.Phone = customer.Phone;
                _customer.CurrencyID = customer.CurrencyID;
                _customer.BillingCountryID = customer.BillingCountryID;
                _customer.BillingProvinceID = customer.BillingProvinceID;
                _customer.BillingAddress1 = customer.BillingAddress1;
                _customer.BillingAddress2 = customer.BillingAddress2;
                _customer.BillingCity = customer.BillingCity;
                _customer.BillingPostal = customer.BillingPostal;
                _customer.HasShippingAddress = customer.HasShippingAddress;
                if (customer.HasShippingAddress.HasValue && customer.HasShippingAddress.Value)
                {
                    _customer.ShippingContact = customer.ShippingContact;
                    _customer.ShippingCountryID = customer.ShippingCountryID;
                    _customer.ShippingProvinceID = customer.ShippingProvinceID;
                    _customer.ShippingAddress1 = customer.ShippingAddress1;
                    _customer.ShippingAddress2 = customer.ShippingAddress2;
                    _customer.ShippingCity = customer.ShippingCity;
                    _customer.ShippingPostal = customer.ShippingPostal;
                    _customer.ShippingPhone = customer.ShippingPhone;
                    _customer.DeliveryInstructions = customer.DeliveryInstructions;
                }
                _customer.AccountNumber = customer.AccountNumber;
                _customer.Fax = customer.Fax;
                _customer.Mobile = customer.Mobile;
                _customer.TollFree = customer.TollFree;
                _customer.Website = customer.Website;
                _customer.InternalNotes = customer.InternalNotes;
                _customer.CreatedDate = DateTime.Now;
                _customer.CreatedBy = _username;
                _customer.ModifiedDate = DateTime.Now;
                _customer.ModifiedBy = _username;

                await _customerRepository.AddAsync(_customer);
            }
            catch (Exception ex)
            {
                Log.Error("CreateCustomerAsync failed:" + ex.Message);
            }
        }

        public async Task<CustomerItemViewModel> GetCustomerItem(int customerId)
        {
            await LogUsername();
            Log.Information("GetCustomerItem started by:" + _username);

            try
            {
                var customer = await _customerRepository.GetByIdAsync(customerId);

                Guard.Against.NullCustomer(customerId, customer);

                var vm = new CustomerItemViewModel()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Contact1 = customer.Contact1,
                    Contact2 = customer.Contact2,
                    Phone = customer.Phone,
                    CurrencyID = customer.CurrencyID,
                    BillingCountryID = customer.BillingCountryID,
                    BillingProvinceID = customer.BillingProvinceID,
                    BillingAddress1 = customer.BillingAddress1,
                    BillingAddress2 = customer.BillingAddress2,
                    BillingCity = customer.BillingCity,
                    BillingPostal = customer.BillingPostal,
                    HasShippingAddress = customer.HasShippingAddress,
                    ShippingContact = customer.ShippingContact,
                    ShippingCountryID = customer.ShippingCountryID,
                    ShippingProvinceID = customer.ShippingProvinceID,
                    ShippingAddress1 = customer.ShippingAddress1,
                    ShippingAddress2 = customer.ShippingAddress2,
                    ShippingCity = customer.ShippingCity,
                    ShippingPostal = customer.ShippingPostal,
                    ShippingPhone = customer.ShippingPhone,
                    DeliveryInstructions = customer.DeliveryInstructions,
                    AccountNumber = customer.AccountNumber,
                    Fax = customer.Fax,
                    Mobile = customer.Mobile,
                    TollFree = customer.TollFree,
                    Website = customer.Website,
                    InternalNotes = customer.InternalNotes,
                    CreatedDate = customer.CreatedDate,
                    CreatedBy = customer.CreatedBy,
                    ModifiedDate = customer.ModifiedDate,
                    ModifiedBy = customer.ModifiedBy
                };

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetCustomerItem failed:" + ex.Message);

                var vm = new CustomerItemViewModel();

                return vm;
            }
        }

        public async Task<int> GetDuplicateCount(string customername)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new CustomerFilterSpecification(customername);

                var totalItems = await _customerRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<int> GetDuplicateCount(string customername, int id)
        {
            await LogUsername();
            Log.Information("GetDuplicateCount started by:" + _username);

            try
            {
                var filterSpecification = new CustomerFilterSpecification(customername, id);

                var totalItems = await _customerRepository.CountAsync(filterSpecification);

                return totalItems;
            }
            catch (Exception ex)
            {
                Log.Error("GetDuplicateCount failed:" + ex.Message);
                return -1;
            }
        }

        public async Task<ErrorViewModel> UploadCustomerData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file)
        {
            Log.Information("UploadFile started by:" + _username);
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
                        "customer_name",
                        "email",
                        "contact_first_name",
                        "contact_last_name",
                        "customer_currency",
                        "account_number",
                        "phone",
                        "fax",
                        "mobile",
                        "toll_free",
                        "website",
                        "country",
                        "province/state",
                        "address_line_1",
                        "address_line_2",
                        "city",
                        "postal_code/zip_code",
                        "shipping_address",
                        "ship-to_contact",
                        "ship-to_country",
                        "ship-to_province/state",
                        "ship-to_address_line_1",
                        "ship-to_address_line_2",
                        "ship-to_city",
                        "ship-to_postal_code/zip_code",
                        "ship-to_phone",
                        "delivery_instructions"
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
                                if (j > 26)
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

                            int firstRow = worksheet.UsedRange.Row;
                            int lastRow = worksheet.UsedRange.LastRow;

                            for (int i = (firstRow + 1); i < lastRow; i++) //Read Excel File
                            {
                                IRange row = worksheet.Rows[i];
                                if (row == null) continue;
                                if (row.IsBlank) continue;


                                var name = row.Cells[0]?.CalculatedValue.Trim();

                                var filterSpecification = new CustomerFilterSpecification(name);
                                var customer = await _customerRepository.ListAsync(filterSpecification);

                                var _customer = new Customers();
                                if (customer.Count() > 0)
                                {
                                    _customer = customer[0];
                                }

                                _customer.Name = name;
                                _customer.Email = row.Cells[1]?.CalculatedValue.Trim();
                                _customer.Contact1 = row.Cells[2]?.CalculatedValue.Trim();
                                _customer.Contact2 = row.Cells[3]?.CalculatedValue.Trim();

                                var currency = row.Cells[4]?.CalculatedValue.Trim();
                                if (string.IsNullOrEmpty(currency))
                                {
                                    _customer.CurrencyID = null;
                                }
                                else
                                {
                                    if (currency == "CAD")
                                        currency = "CAD - Canadian dollar";

                                    var currencyid = _dbContext.Currency.Where(p => p.Name == currency).Select(p => p.Id).FirstOrDefault();

                                    _customer.CurrencyID = currencyid;
                                }

                                _customer.AccountNumber = row.Cells[5]?.CalculatedValue.Trim();
                                _customer.Phone = row.Cells[6]?.CalculatedValue.Trim();
                                _customer.Fax = row.Cells[7]?.CalculatedValue.Trim();
                                _customer.Mobile = row.Cells[8]?.CalculatedValue.Trim();
                                _customer.TollFree = row.Cells[9]?.CalculatedValue.Trim();
                                _customer.Website = row.Cells[10]?.CalculatedValue.Trim();

                                var country = row.Cells[11]?.CalculatedValue.Trim();
                                if (string.IsNullOrEmpty(country))
                                {
                                    _customer.BillingCountryID = null;
                                }
                                else
                                {
                                    var countryid = _dbContext.Country.Where(p => p.Name.ToLower() == country.ToLower()).Select(p => p.Id).FirstOrDefault();

                                    _customer.BillingCountryID = countryid;
                                }

                                var province = row.Cells[12]?.CalculatedValue.Trim();
                                if (string.IsNullOrEmpty(province))
                                {
                                    _customer.BillingProvinceID = null;
                                }
                                else
                                {
                                    var provinceid = _dbContext.Province.Where(p => p.Name.ToLower() == province.ToLower()).Select(p => p.Id).FirstOrDefault();

                                    _customer.BillingProvinceID = provinceid;
                                }

                                _customer.BillingAddress1 = row.Cells[13]?.CalculatedValue.Trim();
                                _customer.BillingAddress2 = row.Cells[14]?.CalculatedValue.Trim();
                                _customer.BillingCity = row.Cells[15]?.CalculatedValue.Trim();
                                _customer.BillingPostal = row.Cells[16]?.CalculatedValue.Trim();

                                var hasshipping = row.Cells[17]?.CalculatedValue.Trim();
                                if (string.IsNullOrEmpty(hasshipping))
                                {
                                    _customer.HasShippingAddress = null;
                                }
                                else
                                {
                                    if (bool.TryParse(hasshipping, out bool sa))
                                    {
                                        _customer.HasShippingAddress = sa;
                                    }
                                }

                                if (_customer.HasShippingAddress.HasValue && _customer.HasShippingAddress.Value)
                                {
                                    //add later to update shipping address
                                }

                                _customer.ModifiedDate = DateTime.Now;
                                _customer.ModifiedBy = _username;

                                if (customer.Count() == 0)
                                {
                                    _customer.CreatedDate = DateTime.Now;
                                    _customer.CreatedBy = _username;

                                    await _customerRepository.AddAsync(_customer);
                                }
                                else
                                {
                                    await _customerRepository.UpdateAsync(_customer);
                                }

                                error.message = "Customer data has been imported successfully.";
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
                Log.Error("ImportCustomers failed:" + ex.Message);

                errormessage = "File imports failed. Please check the log file for more information.";

                error.message = message;
                error.errormessage = errormessage;
                return error;
            }
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
                var ordered = countries.OrderBy(t => t.Name);

                foreach (Country org in ordered)
                {
                    items.Add(new SelectListItem() { Value = org.Id.ToString(), Text = org.Name });
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

                    var ordered = province.OrderBy(t => t.Name);

                    foreach (Province prov in ordered)
                    {
                        items.Add(new SelectListItem() { Value = prov.Id.ToString(), Text = prov.Name });
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

        public async Task<IEnumerable<SelectListItem>> GetCurrencies()
        {
            await LogUsername();
            Log.Information("GetCurrencies started by:" + _username);

            try
            {
                var curr = await _currencyRepository.ListAllAsync();

                var items = new List<SelectListItem>
                {
                    new SelectListItem() { Value = "0", Text = "Choose One...", Selected = true }
                };
                var ordered = curr.OrderBy(t => t.Name);

                foreach (Currency cu in ordered)
                {
                    items.Add(new SelectListItem() { Value = cu.Id.ToString(), Text = cu.Name });
                }

                return items;
            }
            catch (Exception ex)
            {
                Log.Error("GetCurrencies failed:" + ex.Message);

                var vm = new List<SelectListItem>();

                return vm;
            }
        }

        public string GetURLPath()
        {
            return _dbContext.SystemConfigurations.Where(p => p.FieldName == "InvoiceURL").Select(p => p.FieldValue).FirstOrDefault();
        }
    }
}
