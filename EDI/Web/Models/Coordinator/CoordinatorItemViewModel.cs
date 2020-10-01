using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class CoordinatorItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "User is required.")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
        public string CoordinatorName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
