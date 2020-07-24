using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EDI2020.DAL.Data
{
    public class EDI2020IdentityContext : IdentityDbContext
    {
        public EDI2020IdentityContext(DbContextOptions<EDI2020IdentityContext> options) : base(options)
        {

        }
    }
}