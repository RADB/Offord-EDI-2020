using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class LookupSetItemViewModel : BaseModel
    {
        [Required(ErrorMessage = "Lookup Name is required.")]
        public string LookupName { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        public string EdiyearString { get; set; }
    }
}
