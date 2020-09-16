using System;
using System.ComponentModel.DataAnnotations;


namespace EDI.Web.Models
{
    public class ChildItemViewModel
    {
        public int Id { get; set; }
        public string Ediid { get; set; }
        public string LocalId { get; set; }
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        public int? TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int? GenderId { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string PostalCodeZip { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
