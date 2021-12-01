using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class ProvinceItemViewModel : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string English { get; set; }
        public string French { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        public byte? EDICode { get; set; }

        public int CountryID { get; set; }
        public string Country { get; set; }

        public int? ProvinceTypeId { get; set; }
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
    }
}
