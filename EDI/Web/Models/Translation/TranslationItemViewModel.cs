using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class TranslationItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "English is required.")]
        public string English { get; set; }
        public string French { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
