using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class SwitchViewModel
    {
        public string Name { get; set; }
        public bool Value { get; set; }
        public string OnLabel { get; set; }
        public string OffLabel { get; set; }
    }
}
