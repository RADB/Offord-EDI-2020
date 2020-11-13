using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class TranslationItemViewModel : BaseModel
    {

        [Required(ErrorMessage = "English is required.")]
        public string English { get; set; }
        public string French { get; set; }
    }
}
