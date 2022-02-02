using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ICoordinatorService
    {
        Task DeleteCoordinatorAsync(int Id);

        Task UpdateCoordinatorAsync(CoordinatorItemViewModel coordinator);

        Task<int> CreateCoordinatorAsync(CoordinatorItemViewModel coordinator);

        Task<CoordinatorItemViewModel> GetCoordinatorItem(int coordinatorId);

        Task<int> GetDuplicateCount(string name, string email, int yearid);
        Task<int> GetDuplicateCount(string name, string email, int yearid, int id);
    }
}
