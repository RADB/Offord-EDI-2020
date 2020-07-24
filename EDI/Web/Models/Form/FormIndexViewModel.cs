using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EDI.Web.Models
{
    public class FormIndexViewModel
    {
        public IEnumerable<FormItemViewModel> FormItems { get; set; }
    }
}
