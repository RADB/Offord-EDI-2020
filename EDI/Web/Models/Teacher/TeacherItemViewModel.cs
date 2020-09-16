using System;
using System.ComponentModel.DataAnnotations;


namespace EDI.Web.Models
{
    public class TeacherItemViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string TeacherNumber { get; set; }
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        public int? SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolNumber { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
