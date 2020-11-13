using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class FormItemViewModel : BaseModel
    {
        public string FormName { get; set; }

        public string FieldName { get; set; }

        public int Order { get; set; }

        public bool IsRequired { get; set; }

        public bool IsVisible { get; set; }

        public bool IsEnabled { get; set; }
    }
}
