using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class ConfigurationItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field Name is required.")]
        public string FieldName { get; set; }

        [Required(ErrorMessage = "Field Value is required.")]
        public string FieldValue { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
