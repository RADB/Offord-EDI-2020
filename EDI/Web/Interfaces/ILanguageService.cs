using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ILanguageService
    {
        Task DeleteLanguageAsync(int Id);

        Task UpdateLanguageAsync(LanguageItemViewModel language);

        Task CreateLanguageAsync(LanguageItemViewModel language);

        Task<LanguageItemViewModel> GetLanguageItem(int languageId);

        Task<int> GetDuplicateCount(string languagecode);
        Task<int> GetDuplicateCount(string languagecode, int id);
    }
}
