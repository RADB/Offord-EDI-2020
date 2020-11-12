using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class NewsFeedItemViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
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
