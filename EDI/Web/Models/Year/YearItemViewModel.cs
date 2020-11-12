using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class YearItemViewModel:BaseModelProvince
    {
       // public int Id { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(2000, 2100)]
        public short? Ediyear { get; set; }
        /*public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }*/
    }
}
