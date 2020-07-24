using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class ExistingAccountItemViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Lockout { get; set; }

        public bool? LockoutEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }

        public bool? EmailConfirmed { get; set; }

        public bool? PhoneNumberConfirmed { get; set; }

        public bool? TwoFactorEnabled { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }        

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }

        public string Scheme { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Organization is required.")]
        [Display(Name = "Organization")]
        public int? OrganizationId { get; set; }

        public string Organization { get; set; }

        public IEnumerable<SelectListItem> Organizations { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }

        [Display(Name = "Role")]
        public string RoleID { get; set; }

        public string RoleName { get; set; }

        public int? CountryID { get; set; }

        public string  Country { get; set; }

        public int? ProvinceID { get; set; }

        public string Province { get; set; }
    }
}
