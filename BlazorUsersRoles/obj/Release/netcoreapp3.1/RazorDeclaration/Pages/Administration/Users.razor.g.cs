// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUsersRoles.Pages.Administration
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using BlazorUsersRoles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\_Imports.razor"
using BlazorUsersRoles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\Pages\Administration\Users.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\Pages\Administration\Users.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\Pages\Administration\Users.razor"
using BlazorUsersRoles.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\andre\source\repos\Sources\Offord-EDI-2020\BlazorUsersRoles\Pages\Administration\Users.razor"
       
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        string ADMINISTRATION_ROLE = "Administrators";
        System.Security.Claims.ClaimsPrincipal CurrentUser;

        // Property used to add or edit the currently selected user
        IdentityUser objUser = new IdentityUser();

        // Tracks the selected role for the currently selected user
        string CurrentUserRole { get; set; } = "Users";

        // Collection to display the existing users
        List<IdentityUser> ColUsers = new List<IdentityUser>();
    // Collection to display the existing users
    public List<IdentityRole> ColRoles = new List<IdentityRole>();

    // Options to display in the roles dropdown when editing a user
    //List<string> Options = new List<string>() { "Users", "Administrators" };
    List<String> Options = new List<String>();  //Get the list of roles from the database

    List<String> UsersRoles = new List<String>(); //get the users roles

    List<ASPNETRole> SystemRoles = new List<ASPNETRole>();

    // To hold any possible errors
    string strError = "";

    // To enable showing the Popup
    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        // ensure there is a ADMINISTRATION_ROLE
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            // Create ADMINISTRATION_ROLE Role
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }

        // Ensure a user named Admin@BlazorHelpWebsite.com is an Administrator
        var user = await _UserManager.FindByNameAsync("Admin@BlazorHelpWebsite.com");
        if (user != null)
        {
            // Is Admin@BlazorHelpWebsite.com in administrator role?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                // Put admin in Administrator role
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }

        // Get the current logged in user
        CurrentUser = (await authenticationStateTask).User;

        // Get the users
        GetUsers();

        // get the roles
        Options = GetRoles();

        ColRoles = GetIdentityRoles();

        SystemRoles = GetASPNETRoles();

        var userRoles = await _UserManager.GetRolesAsync(await _UserManager.FindByNameAsync(CurrentUser.Identity.Name));
    }

    public List<IdentityRole> GetIdentityRoles()
    {
        // Collection of roles
        var ColIdentityRoles = new List<IdentityRole>();

        // get roles from _RoleManager
        var role = _RoleManager.Roles.Select(x => new IdentityRole
        {
            Id = x.Id,
            Name = x.Name,
            NormalizedName = x.NormalizedName,
            ConcurrencyStamp = x.ConcurrencyStamp
        });

        foreach (var item in role)
        {
            ColIdentityRoles.Add(new IdentityRole { Id=item.Id, Name= item.Name});
        }

        return ColIdentityRoles;
    }

    public List<string> GetRoles()
    {
        // Collection of roles
        var ColRolesStrings = new List<String>();

        // get roles from _RoleManager
        var role = _RoleManager.Roles.Select(x => new IdentityRole
        {
            Id = x.Id,
            Name = x.Name,
            NormalizedName = x.NormalizedName,
            ConcurrencyStamp = x.ConcurrencyStamp
        });

        foreach (var item in role)
        {
            ColRolesStrings.Add(item.Name.ToString());
        }

        return ColRolesStrings;
    }

    public List<ASPNETRole> GetASPNETRoles()
    {
        // Collection of roles
        var ColASPNETRoles = new List<ASPNETRole>();

        // get roles from _RoleManager
        var role = _RoleManager.Roles.Select(x => new IdentityRole
        {
            Id = x.Id,
            Name = x.Name,
            NormalizedName = x.NormalizedName,
            ConcurrencyStamp = x.ConcurrencyStamp
        });

        foreach (var item in role)
        {
            ColASPNETRoles.Add(new ASPNETRole { RoleID = item.Id, Name = item.Name });
        }

        return ColASPNETRoles;
    }

    public void GetUsers()
    {
        // clear any error messages
        strError = "";

        // Collection to hold users
        ColUsers = new List<IdentityUser>();

        // get users from _UserManager
        var user = _UserManager.Users.Select(x => new IdentityUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email = x.Email,
            PasswordHash = "*****"
        });

        foreach (var item in user)
        {
            ColUsers.Add(item);
        }
    }

    void AddNewUser()
    {
        // Make new user
        objUser = new IdentityUser();
        objUser.PasswordHash = "*****";

        // Set Id to blank so we know it is a new record
        objUser.Id = "";

        // Open the Popup
        ShowPopup = true;
    }

    async Task SaveUser()
    {
        try
        {
            // Is this an existing user?
            if (objUser.Id != "")
            {
                // Get the user
                var user = await _UserManager.FindByIdAsync(objUser.Id);

                // Update Email
                user.Email = objUser.Email;

                // Update the user
                await _UserManager.UpdateAsync(user);

                // Only update password if the current value
                // is not the default value
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken =
                        await _UserManager.GeneratePasswordResetTokenAsync(user);

                    var passworduser =
                        await _UserManager.ResetPasswordAsync(
                            user,
                            resetToken,
                            objUser.PasswordHash);

                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError =
                                passworduser
                                .Errors
                                .FirstOrDefault()
                                .Description;
                        }
                        else
                        {
                            strError = "Pasword error";
                        }

                        // Keep the popup opened
                        return;
                    }
                }

                // Handle Roles

                if (user != null)
                {
                    var userRoles = await _UserManager.GetRolesAsync(user);
                    // get the existing role from the database

                    //CurrentUserRole holds the selected role from the dropdown
                    if (CurrentUserRole != userRoles[0])
                    {
                        //remove the old role
                        await _UserManager.RemoveFromRoleAsync(user, userRoles[0]);

                        // Put user in selected role
                        await _UserManager.AddToRoleAsync(user, CurrentUserRole);
                    }
                }
            }
            else
            {
                // Insert new user

                var NewUser =
                    new IdentityUser
                    {
                        UserName = objUser.UserName,
                        Email = objUser.Email
                    };

                var CreateResult =
                    await _UserManager
                    .CreateAsync(NewUser, objUser.PasswordHash);

                if (!CreateResult.Succeeded)
                {
                    if (CreateResult
                        .Errors
                        .FirstOrDefault() != null)
                    {
                        strError =
                            CreateResult
                            .Errors
                            .FirstOrDefault()
                            .Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }

                    // Keep the popup opened
                    return;
                }
                else
                {
                    // Handle Roles

                    // Put user in selected role
                    await _UserManager
                        .AddToRoleAsync(NewUser, CurrentUserRole);
                }
            }

            // Close the Popup
            ShowPopup = false;

            // Refresh Users
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }

    async Task EditUser(IdentityUser _IdentityUser)
    {
        // Set the selected user
        // as the current user
        objUser = _IdentityUser;

        // Get the user
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            var userRoles = await _UserManager.GetRolesAsync(user);

            CurrentUserRole = userRoles[0];
        }

        // Open the Popup
        ShowPopup = true;
    }

    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;

        // Get the user
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Delete the user
            await _UserManager.DeleteAsync(user);
        }

        // Refresh Users
        GetUsers();
    }

    async Task DeleteUser(IdentityUser _IdentityUser)
    {
        // Delete the user        
        try
        {
            var user = await _UserManager.FindByIdAsync(_IdentityUser.Id);
            if (user != null)
            {

                var result = await _UserManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    strError = result.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }

        // Refresh Users
        GetUsers();
    }

    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
