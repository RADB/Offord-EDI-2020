using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class FileItemViewModel : BaseModel
    {
        public string FileName { get; set; }
        public string SiteName { get; set; }
        public string CoordinatorName { get; set; }
        public string CoordinatorEmail { get; set; }
        public string SchoolName { get; set; }
       // public int? SchoolProvinceId { get; set; }
       // public string Province { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string LocalId { get; set; }
       // public byte? ClassTime { get; set; }
        public int? GenderId { get; set; }
        public string Gender { get; set; }
        public DateTime? ChildDob { get; set; }
        public string ChildPostalCodeZip { get; set; }
        public string ChildEdiid { get; set; }
        public int? FileImportStatusId { get; set; }
        public string FileImportStatus { get; set; }
    }
}
