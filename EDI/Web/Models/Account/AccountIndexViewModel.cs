using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EDI.Web.Models
{
    public class AccountIndexViewModel
    {
        public IEnumerable<AccountItemViewModel> AccountItems { get; set; }

        public int? TotalItems { get; set; }

        public string CurrentUserRole { get; set; }

        public IEnumerable<SelectListItem> Organizations { get; set; }
    }
}
