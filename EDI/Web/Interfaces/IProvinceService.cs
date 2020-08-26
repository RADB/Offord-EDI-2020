using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IProvinceService
    {
        Task DeleteProvinceAsync(int Id);

        Task UpdateProvinceAsync(ProvinceItemViewModel province);

        Task CreateProvinceAsync(ProvinceItemViewModel province);

        Task<ProvinceItemViewModel> GetProvinceItem(int provinceId);

        Task<int> GetDuplicateCount(int countryid, string name);
        Task<int> GetDuplicateCount(int countryid, string name, int id);
    }
}
