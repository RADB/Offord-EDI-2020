using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EDI.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<EDIApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // add the roles
            string[] roleNames={ "Administrator","Teacher","Coordinator"};
            foreach (string roleName in roleNames)
            {
                await CreateRoleAsync(roleManager, roleName);
            }                       

            await CreateUserAsync(userManager, "andrew.renner@phri.ca", "McMaster2021", "Administrator");
            await CreateUserAsync(userManager, "bryan.deng@phri.ca", "EDI&ict2020", "Administrator");
            await CreateUserAsync(userManager, "aofford@mcmaster.ca", "McMaster2021", "Administrator");
            await CreateUserAsync(userManager, "agaskin@mcmaster.ca", "McMaster2021", "Administrator");
            await CreateUserAsync(userManager, "paraso@mcmaster.ca", "McMaster2021", "Administrator");
            await CreateUserAsync(userManager, "ashlynn@renner.ca", "McMaster2021", "Teacher");

        }

        private static async Task CreateUserAsync(UserManager<EDIApplicationUser> userManager, string User, string Password, string Role)
        {
            var adminuser = await userManager.FindByNameAsync(User);

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
