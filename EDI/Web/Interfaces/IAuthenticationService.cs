using EDI.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IAuthenticationService
    {
        ApplicationUser Login(string username, string password, string domain);
    }
}
