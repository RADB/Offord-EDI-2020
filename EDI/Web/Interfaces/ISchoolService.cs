using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ISchoolService
    {
        Task DeleteSchoolAsync(int Id);

        Task UpdateSchoolAsync(SchoolItemViewModel school);

        Task<int> CreateSchoolAsync(SchoolItemViewModel school);

        Task<SchoolItemViewModel> GetSchoolItem(int schoolId);

        Task<int> GetDuplicateCount(int siteid, string schoolnumber, int yearid);
        Task<int> GetDuplicateCount(int siteid, string schoolnumber, int id, int yearid);
    }
}
