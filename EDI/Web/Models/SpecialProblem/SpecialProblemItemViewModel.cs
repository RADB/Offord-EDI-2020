using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class SpecialProblemItemViewModel : BaseModel
    {
        [Required(ErrorMessage = "Special Problem Code is required.")]
        public string Code { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public int? Sequence { get; set; }
    }
}
