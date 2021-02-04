using EDI.ApplicationCore.Entities;
using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IChildService
    {
        Task DeleteChildAsync(int Id);

        Task UpdateChildAsync(ChildItemViewModel child);

        Task<int> CreateChildAsync(ChildItemViewModel child);

        Task<ChildItemViewModel> GetChildItem(int childId);

        Task<int> GetDuplicateCount(string ediid);
        Task<int> GetDuplicateCount(string ediid, int id);
        Task UnlockChildAsync(int id);
        int GetCompletedQuestions(int id);
        int GetRequiredQuestions(int id);
        int GetPercentComplete(int id, int numberOfQuestionnaires);

        Task GetChildrenAsync();
    }
}
