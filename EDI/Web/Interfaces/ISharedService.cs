using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.ApplicationCore.Entities;
using EDI.ApplicationCore.Models;
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
        Task<IEnumerable<SelectListItem>> GetSchools(int siteid);
        Task<IEnumerable<SelectListItem>> GetTeachers(int schoolid);
        
       // List<LookupSetOption> GetLookupSetOptions(int LookupSetId);

        Task<ErrorViewModel> UploadFileData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file);
        Task<ErrorViewModel> ProcessFileData();
        Task<ErrorViewModel> UploadTranslationData(Syncfusion.Blazor.Inputs.Internal.UploadFiles file);
        string GetConfigText(QuestionnairesConfiguration config);

        string GetOptionText(LookupSetOption option);

        string GetTranslate(string english);
        string GetImagePath();
        Task<string> SendEmail(EmailModel EmailModel);
    }
}
