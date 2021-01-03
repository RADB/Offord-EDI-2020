using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EDI.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<EDIApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // add the 3 roles
            await CreateRoleAsync(roleManager, "Administrator");
            await CreateRoleAsync(roleManager, "Teacher");
            await CreateRoleAsync(roleManager, "Coordinator");

            await CreateUserAsync(userManager, "andrew.renner@phri.ca", "EDI&ict2020", "Adminsitrator");
            await CreateUserAsync(userManager, "bryan.deng@phri.ca", "EDI&ict2020", "Adminsitrator"); 
        }

        private static async Task CreateUserAsync(UserManager<EDIApplicationUser> userManager, string User, string Password, string Role)
        {
            var adminuser = await userManager.FindByNameAsync("");

            if (adminuser == null)
            {
                var defaultUser = new EDIApplicationUser { UserName = User, Email = User };
                await userManager.CreateAsync(defaultUser, Password);
                await userManager.SetLockoutEnabledAsync(defaultUser, false);
                await userManager.AddToRoleAsync(defaultUser, Role);
            }
        }

        private static async Task CreateRoleAsync(RoleManager<IdentityRole> roleManager, string RoleName)
        {           
            bool roleExist = await roleManager.RoleExistsAsync(RoleName);

            if (!roleExist)
            {
                var role = new IdentityRole(RoleName);
                await roleManager.CreateAsync(role);
            }
        }
    }
}
