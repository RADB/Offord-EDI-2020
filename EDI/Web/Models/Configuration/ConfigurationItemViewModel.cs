using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class ConfigurationItemViewModel: BaseModel
    {
        [Required(ErrorMessage = "Field Name is required.")]
        public string FieldName { get; set; }

        [Required(ErrorMessage = "Field Value is required.")]
        public string FieldValue { get; set; }
    }
}
