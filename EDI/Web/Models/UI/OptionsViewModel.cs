using EDI.ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class OptionsViewModel
    {
        public int? ID { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public string Placeholder { get; set; }
        
        public List<LookupSetOption> LookupSetOptions;


    }
}
