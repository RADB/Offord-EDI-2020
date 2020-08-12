using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ISpecialProblemService
    {
        Task DeleteSpecialProblemAsync(int Id);

        Task UpdateSpecialProblemAsync(SpecialProblemItemViewModel specialProblem);

        Task CreateSpecialProblemAsync(SpecialProblemItemViewModel specialProblem);

        Task<SpecialProblemItemViewModel> GetSpecialProblemItem(int specialProblemId);

        Task<int> GetDuplicateCount(string specialProblemcode);
        Task<int> GetDuplicateCount(string specialProblemcode, int id);
    }
}
