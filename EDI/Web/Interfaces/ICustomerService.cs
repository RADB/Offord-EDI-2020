using BlazorInputFile;
using EDI.ApplicationCore.Models;
using EDI.Web.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EDI.Web.Interfaces
{
    public interface ICustomerService
    {
        Task DeleteCustomerAsync(int Id);
        Task UpdateCustomerAsync(CustomerItemViewModel customer);
        Task CreateCustomerAsync(CustomerItemViewModel customer);
        Task<CustomerItemViewModel> GetCustomerItem(int customerId);
        Task<int> GetDuplicateCount(string customername);
        Task<int> GetDuplicateCount(string customername, int id);
        Task<ErrorViewModel> UploadCustomerData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file);
        Task<IEnumerable<SelectListItem>> GetCountries();
        Task<IEnumerable<SelectListItem>> GetProvinces(int countryid);
        Task<IEnumerable<SelectListItem>> GetCurrencies();
        string GetURLPath();
    }
}
