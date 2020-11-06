using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class LookupSetOptionItemViewModel
    {
        public int Id { get; set; }
        public int LookupId { get; set; }
       
        [Required(ErrorMessage = "English is required.")]
        public string English { get; set; }
        public string French { get; set; }
        [Required(ErrorMessage = "Value is required.")]
        public byte Value { get; set; }
        [Required(ErrorMessage = "Sequence is required.")]
        public short Sequence { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        public string EdiyearString { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
