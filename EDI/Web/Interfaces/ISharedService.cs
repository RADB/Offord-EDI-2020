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

        Task<ErrorViewModel> UploadFileData(Syncfusion.Blazor.Inputs.UploadFiles file);
        Task<ErrorViewModel> ProcessFileData();
        Task<ErrorViewModel> UploadTranslationData(Syncfusion.Blazor.Inputs.UploadFiles file);
        string GetConfigText(QuestionnairesConfiguration config);

        string GetHelpText(QuestionnairesConfiguration config);

        string GetOptionText(LookupSetOption option);

        string GetQuestionnaireText(Questionnaire q);
        string GetTranslate(string english);
        string GetImagePath();
        Task<string> SendEmail(EmailModel EmailModel);
        void SendException(string exceptionmsg, string innermsg, string filename, string methodname);
        IEnumerable<SelectListItem> GetInpuTypes();
        IEnumerable<SelectListItem> GetEntities();
        Task<IEnumerable<SelectListItem>> GetFields(string entityname);
        IEnumerable<SelectListItem> GetOrientations();
        IEnumerable<SelectListItem> GetLookups();
        Task SaveUserSessions(string fieldname, string fieldvalue, string userid);
        Task DeleteUserSessions(string userid);
        void InitializeUserSettings(string username);
        Task ResetPassord(int id);
        void WriteLogs(string message, bool isinfo);
        Task ClearQueue();
        Task<string> SendTeacherPassword(Teacher teacher);

        Task UpdatePercentComplete(int ChildId, byte IsTest);

        //Task<IEnumerable<SelectListItem>> GetReportTypes();
    }
}
