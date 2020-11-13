using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class SiteItemViewModel : BaseModel
    {
        [Required(ErrorMessage = "Site Number is required.")]
        [StringLength(3)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Site number can only contain numbers.")]
        public string SiteNumber { get; set; }

        [StringLength(50)]
        public string SiteName { get; set; }

        public string Description { get; set; }
        public int CoordinatorId { get; set; }
        public string CoordinatorName { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        public int Schools { get; set; }
    }
}
