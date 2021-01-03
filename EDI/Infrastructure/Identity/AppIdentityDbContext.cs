using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EDI.Infrastructure.Identity
{
    public class AppIdentityDbContext : IdentityDbContext<EDIApplicationUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() });
            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Manager", NormalizedName = "Manager".ToUpper() });
            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "User".ToUpper() });

            builder.Entity<EDIApplicationUser>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasColumnName("FirstName")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("LastName")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            });
        }
    }

}
