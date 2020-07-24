using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class AccountItemViewModel
    {
        public string Id { get; set; }
                
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
        
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character.")]
        public string Password { get; set; }
                
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Scheme { get; set; }
                
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
                
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
                
        [Display(Name = "Organization")]
        public int? OrganizationId { get; set; }

        public string Organization { get; set; }

        public IEnumerable<SelectListItem> Organizations { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
                
        [Display(Name = "Role")]
        public string RoleID { get; set; }

        public string RoleName { get; set; }

        public int? CountryID { get; set; }

        public string Country { get; set; }

        public int? ProvinceID { get; set; }

        public string Province { get; set; }
    }
}
