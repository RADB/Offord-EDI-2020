using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class LookupSetOptionItemViewModel : BaseModel
    {
        public int LookupSetId { get; set; }
       
        [Required(ErrorMessage = "English is required.")]
        public string English { get; set; }
        public string French { get; set; }
        [Required(ErrorMessage = "Value is required.")]
        public short Value { get; set; }
        [Required(ErrorMessage = "Sequence is required.")]
        public short Sequence { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        //public short? Ediyear { get; set; }
        public string EdiyearString { get; set; }
    }
}
