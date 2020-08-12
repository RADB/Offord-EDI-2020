using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IYearService
    {
        Task DeleteYearAsync(int Id);

        Task UpdateYearAsync(YearItemViewModel year);

        Task CreateYearAsync(YearItemViewModel year);

        Task<YearItemViewModel> GetYearItem(int yearId);

        Task<int> GetDuplicateCount(int yearnumber);
        Task<int> GetDuplicateCount(int yearnumber, int id);
    }
}
