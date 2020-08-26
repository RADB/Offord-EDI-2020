using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class CountryItemViewModel
    {
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        [StringLength(100)]
        public string English { get; set; }
        public string French { get; set; }

        [Required]
        [StringLength(2)]
        public string ISO2CountryCode { get; set; }

        [Required]
        [StringLength(3)]
        public string ISO3CountryCode { get; set; }

        public DateTime CreatedDate { get; set; }
        
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}
