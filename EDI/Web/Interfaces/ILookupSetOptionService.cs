using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ILookupSetOptionService
    {
        Task DeleteLookupSetOptionAsync(int Id);

        Task UpdateLookupSetOptionAsync(LookupSetOptionItemViewModel lookupSetOption);

        Task CreateLookupSetOptionAsync(LookupSetOptionItemViewModel lookupSetOption);

        Task<LookupSetOptionItemViewModel> GetLookupSetOptionItem(int lookupSetOptionId);
    }
}
