#pragma checksum "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19df71e7110da7a685a77c7775f817cf43d4dae5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUsersRoles.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using BlazorUsersRoles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\_Imports.razor"
using BlazorUsersRoles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administration</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n");
#nullable restore
#line 11 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "            ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "\r\n                ");
                __builder2.AddMarkupContent(8, "<thead>\r\n                    <tr>\r\n                        <th>Id</th>\r\n                        <th>User Name</th>\r\n                        <th>Email</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
                __builder2.OpenElement(9, "tbody");
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 22 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                     foreach (var user in ColUsers)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                        ");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "\r\n                            ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 25 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                 user.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(16, " ...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 26 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                 user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 27 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                 user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddMarkupContent(25, "\r\n                                \r\n                                ");
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "class", "btn btn-primary");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                  (() => EditUser(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(29, "\r\n                                    Edit\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 36 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n");
#nullable restore
#line 39 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(36, "                \r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "modal");
                __builder2.AddAttribute(39, "tabindex", "-1");
                __builder2.AddAttribute(40, "style", "display:block");
                __builder2.AddAttribute(41, "role", "dialog");
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "modal-dialog");
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "modal-content");
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "modal-header");
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.AddMarkupContent(52, "<h3 class=\"modal-title\">Edit User</h3>\r\n                                \r\n                                ");
                __builder2.OpenElement(53, "button");
                __builder2.AddAttribute(54, "type", "button");
                __builder2.AddAttribute(55, "class", "close");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(57, "\r\n                                    ");
                __builder2.AddMarkupContent(58, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                            \r\n                            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "modal-body");
                __builder2.AddMarkupContent(63, "\r\n                                \r\n");
#nullable restore
#line 56 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "                                    ");
                __builder2.OpenElement(65, "p");
                __builder2.AddContent(66, 
#nullable restore
#line 58 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                        objUser.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 59 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "                                \r\n");
#nullable restore
#line 61 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(69, "                                    ");
                __builder2.OpenElement(70, "p");
                __builder2.AddContent(71, 
#nullable restore
#line 63 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                        objUser.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n");
#nullable restore
#line 64 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(73, "                                    ");
                __builder2.OpenElement(74, "input");
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "type", "text");
                __builder2.AddAttribute(77, "placeholder", "UserName");
                __builder2.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                  objUser.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n");
#nullable restore
#line 70 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(81, "                                ");
                __builder2.OpenElement(82, "input");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "type", "text");
                __builder2.AddAttribute(85, "placeholder", "Email");
                __builder2.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                              objUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenElement(89, "input");
                __builder2.AddAttribute(90, "class", "form-control");
                __builder2.AddAttribute(91, "type", "password");
                __builder2.AddAttribute(92, "placeholder", "Password");
                __builder2.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                                ");
                __builder2.OpenElement(96, "select");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                CurrentUserRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentUserRole = __value, CurrentUserRole));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(100, "\r\n");
#nullable restore
#line 79 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                     foreach (var option in Options)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(101, "                                        ");
                __builder2.OpenElement(102, "option");
                __builder2.AddAttribute(103, "value", 
#nullable restore
#line 81 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                        option

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(104, "\r\n                                            ");
                __builder2.AddContent(105, 
#nullable restore
#line 82 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                             option

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(106, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n");
#nullable restore
#line 84 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(108, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                                <br><br>\r\n                                \r\n                                ");
                __builder2.OpenElement(110, "button");
                __builder2.AddAttribute(111, "class", "btn btn-primary");
                __builder2.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                  SaveUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(113, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                \r\n");
#nullable restore
#line 93 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(115, "                                    \r\n                                    ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "class", "btn btn-danger");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                      DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(119, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n");
#nullable restore
#line 100 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(121, "                                <br>\r\n                                ");
                __builder2.OpenElement(122, "span");
                __builder2.AddAttribute(123, "style", "color:red");
                __builder2.AddContent(124, 
#nullable restore
#line 102 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                         strError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n");
#nullable restore
#line 107 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(130, "            ");
                __builder2.OpenElement(131, "button");
                __builder2.AddAttribute(132, "class", "btn btn-success");
                __builder2.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                      AddNewUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(134, "Add User");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n");
#nullable restore
#line 109 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(136, "            ");
                __builder2.OpenElement(137, "p");
                __builder2.AddContent(138, "You\'re not signed in as a user in ");
                __builder2.AddContent(139, 
#nullable restore
#line 112 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
                                                  ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(140, ".");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n");
#nullable restore
#line 113 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(142, "    ");
            }
            ));
            __builder.AddAttribute(143, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(144, "\r\n        ");
                __builder2.AddMarkupContent(145, "<p>You\'re not loggged in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\TEMP\BlazorUsersRoles\BlazorUsersRoles\Pages\Administration.razor"
       
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

    // Options to display in the roles dropdown when editing a user
    List<string> Options = new List<string>() { "Users", "Administrators" };

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

                // Is user in administrator role?
                var UserResult =
                    await _UserManager
                    .IsInRoleAsync(user, ADMINISTRATION_ROLE);

                // Is Administrator role selected
                // but user is not an Administrator?
                if (
                    (CurrentUserRole == ADMINISTRATION_ROLE)
                    &
                    (!UserResult))
                {
                    // Put admin in Administrator role
                    await _UserManager
                        .AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    // Is Administrator role not selected
                    // but user is an Administrator?
                    if ((CurrentUserRole != ADMINISTRATION_ROLE)
                        &
                        (UserResult))
                    {
                        // Remove user from Administrator role
                        await _UserManager
                            .RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
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
                    if (CurrentUserRole == ADMINISTRATION_ROLE)
                    {
                        // Put admin in Administrator role
                        await _UserManager
                            .AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
                    }
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
            // Is user in administrator role?
            var UserResult =
                await _UserManager
                .IsInRoleAsync(user, ADMINISTRATION_ROLE);

            if (UserResult)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            else
            {
                CurrentUserRole = "Users";
            }
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
