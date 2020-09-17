using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EDI.Web.Interfaces
{
    public interface ISharedService
    {
        Task<IEnumerable<SelectListItem>> GetCountries();
        Task<IEnumerable<SelectListItem>> GetProvinces(int countryid);
        Task<IEnumerable<SelectListItem>> GetSites();
        Task<IEnumerable<SelectListItem>> GetCoordinators();
        Task<IEnumerable<SelectListItem>> GetYears();
        Task<IEnumerable<SelectListItem>> GetGenders();
        Task<IEnumerable<SelectListItem>> GetSchools();
        Task<IEnumerable<SelectListItem>> GetTeachers();
        Task<ErrorViewModel> UploadFileData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file);
        Task<ErrorViewModel> ProcessFileData();
    }
}
