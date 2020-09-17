using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ISiteService
    {
        Task DeleteSiteAsync(int Id);

        Task UpdateSiteAsync(SiteItemViewModel site);

        Task CreateSiteAsync(SiteItemViewModel site);

        Task<SiteItemViewModel> GetSiteItem(int siteId);

        Task<int> GetDuplicateCount(string sitenumber);
        Task<int> GetDuplicateCount(string sitenumber, int id);
    }
}
