using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ITeacherService
    {
        Task DeleteTeacherAsync(int Id);

        Task UpdateTeacherAsync(TeacherItemViewModel teacher);

        Task CreateTeacherAsync(TeacherItemViewModel teacher);

        Task<TeacherItemViewModel> GetTeacherItem(int teacherId);
        Task<int> GetDuplicateCount(int schoolid, string teachernumber);
        Task<int> GetDuplicateCount(int schoolid, string teachernumber, int id);

        Task<int> GetDuplicateCount(string teachername, string email);
        Task<int> GetDuplicateCount(string teachername, string email, int id);
    }
}
