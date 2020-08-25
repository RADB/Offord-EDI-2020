using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class SpecialProblemItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Special Problem Code is required.")]
        public string Code { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public int? Sequence { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
