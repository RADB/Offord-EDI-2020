using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class CoordinatorItemViewModel : BaseModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string CoordinatorName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
