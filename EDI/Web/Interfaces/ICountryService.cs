using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ICountryService
    {
        Task DeleteCountryAsync(int Id);

        Task UpdateCountryAsync(CountryItemViewModel country);

        Task CreateCountryAsync(CountryItemViewModel country);

        Task<CountryItemViewModel> GetCountryItem(int countryId);

        Task<int> GetDuplicateCount(int Code, string name);
        Task<int> GetDuplicateCount(int Code, string name, int id);
    }
}
