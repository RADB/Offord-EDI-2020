using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IFaqService
    {
        Task DeleteFaqAsync(int Id);

        Task UpdateFaqAsync(FaqItemViewModel faq);

        Task<int> CreateFaqAsync(FaqItemViewModel faq);

        Task<FaqItemViewModel> GetFaqItem(int faqId);

        Task<int> GetDuplicateCount(string question);
        Task<int> GetDuplicateCount(string question, int id);
    }
}
