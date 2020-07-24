using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EDI.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            bool roleExist = await roleManager.RoleExistsAsync("Administrator");

            if (!roleExist)
            {
                var role = new IdentityRole("Administrator");
                await roleManager.CreateAsync(role);
            }

            roleExist = await roleManager.RoleExistsAsync("General");

            if (!roleExist)
            {
                var role = new IdentityRole("General");
                await roleManager.CreateAsync(role);
            }

            roleExist = await roleManager.RoleExistsAsync("Admin");

            if (roleExist)
            {
                var role = new IdentityRole("Admin");
                await roleManager.DeleteAsync(role);
            }

            roleExist = await roleManager.RoleExistsAsync("Manager");

            if (roleExist)
            {
                var role = new IdentityRole("Manager");
                await roleManager.DeleteAsync(role);
            }

            roleExist = await roleManager.RoleExistsAsync("User");

            if (roleExist)
            {
                var role = new IdentityRole("User");
                await roleManager.DeleteAsync(role);
            }

            var adminuser = await userManager.FindByNameAsync("andrew.renner@phri.ca");

            if (adminuser == null)
            {
                var defaultUser = new ApplicationUser { UserName = "andrew.renner@phri.ca", Email = "andrew.renner@phri.ca" };
                await userManager.CreateAsync(defaultUser, "Andrew&ict2020");
                await userManager.SetLockoutEnabledAsync(defaultUser, false);

                await userManager.AddToRoleAsync(defaultUser, "Administrator");
            }

            var adminuser2 = await userManager.FindByNameAsync("bryan.deng@phri.ca");

            if (adminuser2 == null)
            {
                var defaultUser = new ApplicationUser { UserName = "bryan.deng@phri.ca", Email = "bryan.deng@phri.ca" };
                await userManager.CreateAsync(defaultUser, "EDI&ict2020");
                await userManager.SetLockoutEnabledAsync(defaultUser, false);

                await userManager.AddToRoleAsync(defaultUser, "Administrator");
            }
        }
    }
}
