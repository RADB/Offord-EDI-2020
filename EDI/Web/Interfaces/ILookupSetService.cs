using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface ILookupSetService
    {
        Task DeleteLookupSetAsync(int Id);

        Task UpdateLookupSetAsync(LookupSetItemViewModel lookupSet);

        Task CreateLookupSetAsync(LookupSetItemViewModel lookupSet);

        Task<LookupSetItemViewModel> GetLookupSetItem(int lookupSetId);
    }
}
