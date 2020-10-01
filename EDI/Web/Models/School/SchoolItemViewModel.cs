using System;
using System.ComponentModel.DataAnnotations;


namespace EDI.Web.Models
{
    public class SchoolItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "School Number is required.")]
        [StringLength(3)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "School number can only contain numbers.")]
        public string SchoolNumber { get; set; }
        public string SchoolName { get; set; }
        [Required(ErrorMessage = "Country is required.")]
        public int CountryId { get; set; }
        [Required(ErrorMessage = "Province is required.")]
        public int ProvinceId { get; set; }
        [Required(ErrorMessage = "Site is required.")]
        public int SiteId { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public bool? Elpschool { get; set; }
        public string ElpschoolValue { get; set; }
        public string Description { get; set; }
        public string SiteNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
