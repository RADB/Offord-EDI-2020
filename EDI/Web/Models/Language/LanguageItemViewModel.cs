using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class LanguageItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Language Code is required.")]
        public string LanguageCode { get; set; }
        public string LanguageEnglish { get; set; }
        public string LanguageFrench { get; set; }
        public int? Sequence { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
