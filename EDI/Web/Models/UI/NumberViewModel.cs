using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class NumberViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? Value { get; set; }
        public string Placeholder { get; set; }
    }
}
