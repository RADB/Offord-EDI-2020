using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class YearItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(2000, 2100)]
        public short? Ediyear { get; set; }
        public bool Alberta { get; set; }
        public bool BritishColumbia { get; set; }
        public bool Manitoba { get; set; }
        public bool NewBrunswick { get; set; }
        public bool Newfoundland { get; set; }
        public bool NovaScotia { get; set; }
        public bool Nunavut { get; set; }
        public bool Ontario { get; set; }
        public bool Pei { get; set; }
        public bool Quebec { get; set; }
        public bool Saskatchewan { get; set; }
        public bool Yukon { get; set; }
        public bool Nwt { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
