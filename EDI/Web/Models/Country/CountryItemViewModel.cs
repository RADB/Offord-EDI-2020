using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class CountryItemViewModel : BaseModel
    {
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
    }
}
