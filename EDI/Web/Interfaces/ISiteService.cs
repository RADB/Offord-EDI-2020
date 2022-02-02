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

        Task<int> CreateSiteAsync(SiteItemViewModel site);

        Task<SiteItemViewModel> GetSiteItem(int siteId);

        Task<int> GetDuplicateCount(string sitenumber, int yearid);
        Task<int> GetDuplicateCount(string sitenumber, int id, int yearid);
    }
}
