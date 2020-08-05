using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EDI.Web.Interfaces
{
    public interface ISharedService
    {
        Task<IEnumerable<SelectListItem>> GetCountries();
        Task<IEnumerable<SelectListItem>> GetProvinces(int countryid);
    }
}
