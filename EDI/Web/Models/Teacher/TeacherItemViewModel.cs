using System;
using System.ComponentModel.DataAnnotations;


namespace EDI.Web.Models
{
    public class TeacherItemViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required(ErrorMessage = "Teacher Number is required.")]
        [StringLength(2)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "School number can only contain numbers.")]
        public string TeacherNumber { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        [Required(ErrorMessage = "Site is required.")]
        public int SiteId { get; set; }
        [Required(ErrorMessage = "School is required.")]
        public int? SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolNumber { get; set; }
        [Required(ErrorMessage = "Teacher Name is required.")]
        public string TeacherName { get; set; }
        [Required(ErrorMessage = "Teacher Email is required.")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
