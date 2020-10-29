using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ITranslationService
    {
        Task DeleteTranslationAsync(int Id);

        Task UpdateTranslationAsync(TranslationItemViewModel translation);

        Task CreateTranslationAsync(TranslationItemViewModel translation);

        Task<TranslationItemViewModel> GetTranslationItem(int translationId);

        Task<int> GetDuplicateCount(string english);
        Task<int> GetDuplicateCount(string english, int id);
    }
}
