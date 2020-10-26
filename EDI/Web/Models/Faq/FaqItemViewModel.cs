using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class FaqItemViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        [Required(ErrorMessage = "Question is required.")]
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool? IsTeacherFaq { get; set; }
        public string IsTeacherFaqFormatted { get; set; }
        public bool? IsAdministratorFaq { get; set; }
        public string IsAdministratorFaqFormatted { get; set; }
        public bool? IsCoordinatorFaq { get; set; }
        public string IsCoordinatorFaqFormatted { get; set; }
        public short Sequence { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
