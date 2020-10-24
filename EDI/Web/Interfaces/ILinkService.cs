using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ILinkService
    {
        Task DeleteLinkAsync(int Id);

        Task UpdateLinkAsync(LinkItemViewModel link);

        Task<int> CreateLinkAsync(LinkItemViewModel link);

        Task<LinkItemViewModel> GetLinkItem(int linkId);

        Task<int> GetDuplicateCount(string url);
        Task<int> GetDuplicateCount(string url, int id);
    }
}
