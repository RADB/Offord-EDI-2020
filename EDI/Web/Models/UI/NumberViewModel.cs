using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class NumberViewModel
    {
        public int? Id { get; set; }
        public int? Min { get; set; } = 0;
        public int? Max { get; set; } = 10;
        public int? NumberStep { get; set; } = 1;
        public double? NumberStepDouble { get; set; } = 0.5;
        public string NumberFormat { get; set; } = "n0";
        public string Name { get; set; }
        public int? Value { get; set; }
        public double? ValueDouble { get; set; }
        public string Placeholder { get; set; }
    }
}
