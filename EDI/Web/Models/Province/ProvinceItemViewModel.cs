using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class ProvinceItemViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string English { get; set; }
        public string French { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int CountryID { get; set; }
        public string Country { get; set; }

        public int? ProvinceTypeId { get; set; }

        [Required]
        [StringLength(64)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(64)]
        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
