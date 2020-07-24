using System;
using EDI.Web.Models;
using System.Threading.Tasks;
namespace EDI.Web.Interfaces
{
    public interface IFormService
    {
        Task DeleteFormAsync(int Id);
        Task UpdateFormAsync(FormItemViewModel form);
        Task CreateFormAsync(FormItemViewModel form);
        Task<FormItemViewModel> GetFormItem(string formname, string fieldname, int order);
    }
}
