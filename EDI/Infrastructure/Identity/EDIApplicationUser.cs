using EDI.ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity;

namespace EDI.Infrastructure.Identity
{
    public class EDIApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }

        public int? OrganizationId { get; set; }

        public int? CountryID { get; set; }

        public int? ProvinceID { get; set; }

        public string Language { get; set; }
    }
}
