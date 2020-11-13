using System;
using System.ComponentModel.DataAnnotations;


namespace EDI.Web.Models
{
    public class ChildItemViewModel: BaseModel
    {
        [Required(ErrorMessage = "EDI ID is required.")]
        public string Ediid { get; set; }
        public string LocalId { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        public string EdiyearString { get; set; }
        [Required(ErrorMessage = "Site is required.")]
        public int SiteId { get; set; }
        public string SiteNumber { get; set; }
        [Required(ErrorMessage = "School is required.")]
        public int? SchoolId { get; set; }
        public string SchoolNumber { get; set; }
        public byte? EDICode { get; set; }
        public string EdiCodeString { get; set; }
        [Required(ErrorMessage = "Teacher is required.")]
        public int? TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherNumber { get; set; }
        public int? GenderId { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "DOB is required.")]
        public DateTime? Dob { get; set; }
        public string PostalCodeZip { get; set; }
        public string ChildNumber { get; set; }
        public int? Progress { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
