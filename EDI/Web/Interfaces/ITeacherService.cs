﻿using EDI.Web.Models;
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

        Task<int> CreateTeacherAsync(TeacherItemViewModel teacher);

        Task<TeacherItemViewModel> GetTeacherItem(int teacherId);
        Task<int> GetDuplicateCount(int schoolid, string teachernumber, int yearid);
        Task<int> GetDuplicateCount(int schoolid, string teachernumber, int id, int yearid);

        Task<int> GetDuplicateCount(string teachername, string email, int yearid);
        Task<int> GetDuplicateCount(string teachername, string email, int id, int yearid);
        int GetCompletedQuestions(int id);
        int GetRequiredQuestions(int id);
        Task UnlockTeacherAsync(int id);
    }
}
