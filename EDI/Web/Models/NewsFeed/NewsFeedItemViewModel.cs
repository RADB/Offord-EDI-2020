using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class NewsFeedItemViewModel:BaseModelProvince
    {
        //public int Id { get; set; }
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
    }
}
