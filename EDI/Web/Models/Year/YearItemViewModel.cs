using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class YearItemViewModel:BaseModelProvince
    {
        [Required(ErrorMessage = "Year is required.")]
        [Range(2000, 2100)]
        public short? Ediyear { get; set; }
    }
}
