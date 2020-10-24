using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class LinkItemViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "URL is required.")]
        public string Url { get; set; }
        public string Description { get; set; }
        public bool? IsTeacherLink { get; set; }
        public string IsTeacherLinkFormatted { get; set; }
        public bool? IsAdminLink { get; set; }
        public string IsAdminLinkFormatted { get; set; }
        public bool? IsCoordinatorLink { get; set; }
        public string IsCoordinatorLinkFormatted { get; set; }
        public short Sequence { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
