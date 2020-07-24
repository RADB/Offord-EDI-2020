#pragma checksum "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2cf3b4362089cc5c1b05f44e49277036c20d6e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUsersRoles.Pages.Administration
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using BlazorUsersRoles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\_Imports.razor"
using BlazorUsersRoles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
using BlazorUsersRoles.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration/oldusers")]
    public partial class OldUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administration - Users</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        You Are logged in <br>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Roles", "Administrators");
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        You Are Authorized as an Administrator\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 23 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "            ");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "table");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<thead>\r\n                    <tr>\r\n                        <th>Id</th>\r\n                        <th>User Name</th>\r\n                        <th>Email</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
                __builder2.OpenElement(18, "tbody");
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 35 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                     foreach (var user in ColUsers)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "                        ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 38 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                 user.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " ...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#nullable restore
#line 39 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                 user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "td");
                __builder2.AddContent(31, 
#nullable restore
#line 40 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                 user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "td");
                __builder2.AddMarkupContent(34, "\r\n                                \r\n                                ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "class", "btn btn-primary");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                  (() => EditUser(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(38, "\r\n                                    Edit\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                                \r\n                                ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "class", "btn btn-danger");
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                  (() => DeleteUser(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(43, "\r\n                                    Delete\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
#nullable restore
#line 54 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(47, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n");
#nullable restore
#line 57 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(50, "                \r\n                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "modal");
                __builder2.AddAttribute(53, "tabindex", "-1");
                __builder2.AddAttribute(54, "style", "display:block");
                __builder2.AddAttribute(55, "role", "dialog");
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "modal-dialog");
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "modal-content");
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "modal-header");
                __builder2.AddMarkupContent(65, "\r\n                                ");
                __builder2.AddMarkupContent(66, "<h3 class=\"modal-title\">Edit User</h3>\r\n                                \r\n                                ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "type", "button");
                __builder2.AddAttribute(69, "class", "close");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(71, "\r\n                                    ");
                __builder2.AddMarkupContent(72, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                            \r\n                            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "modal-body");
                __builder2.AddMarkupContent(77, "\r\n                                \r\n");
#nullable restore
#line 74 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(78, "                                    ");
                __builder2.OpenElement(79, "p");
                __builder2.AddContent(80, 
#nullable restore
#line 76 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                        objUser.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 77 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(82, "                                \r\n");
#nullable restore
#line 79 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(83, "                                    ");
                __builder2.OpenElement(84, "p");
                __builder2.AddContent(85, 
#nullable restore
#line 81 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                        objUser.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n");
#nullable restore
#line 82 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(87, "                                    ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "type", "text");
                __builder2.AddAttribute(91, "placeholder", "UserName");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                  objUser.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n");
#nullable restore
#line 88 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(95, "                                ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "type", "text");
                __builder2.AddAttribute(99, "placeholder", "Email");
                __builder2.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                              objUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                                ");
                __builder2.OpenElement(103, "input");
                __builder2.AddAttribute(104, "class", "form-control");
                __builder2.AddAttribute(105, "type", "password");
                __builder2.AddAttribute(106, "placeholder", "Password");
                __builder2.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                                ");
                __builder2.OpenElement(110, "select");
                __builder2.AddAttribute(111, "class", "form-control");
                __builder2.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                CurrentUserRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentUserRole = __value, CurrentUserRole));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(114, "\r\n");
#nullable restore
#line 97 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                     foreach (var role in ColRoles)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(115, "                                        ");
                __builder2.OpenElement(116, "option");
                __builder2.AddAttribute(117, "value", 
#nullable restore
#line 99 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                        role.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(118, "\r\n                                            ");
                __builder2.AddContent(119, 
#nullable restore
#line 100 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                             role.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(120, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n");
#nullable restore
#line 102 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                                <br><br>\r\n                                \r\n                                ");
                __builder2.OpenElement(124, "button");
                __builder2.AddAttribute(125, "class", "btn btn-primary");
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                  SaveUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(127, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                                \r\n");
#nullable restore
#line 111 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(129, "                                    \r\n                                    ");
                __builder2.OpenElement(130, "button");
                __builder2.AddAttribute(131, "class", "btn btn-danger");
                __builder2.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                      DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(133, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n");
#nullable restore
#line 118 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(135, "                                <br>\r\n                                ");
                __builder2.OpenElement(136, "span");
                __builder2.AddAttribute(137, "style", "color:red");
                __builder2.AddContent(138, 
#nullable restore
#line 120 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                         strError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n");
#nullable restore
#line 125 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(144, "            ");
                __builder2.OpenElement(145, "button");
                __builder2.AddAttribute(146, "class", "btn btn-success");
                __builder2.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                      AddNewUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(148, "Add User");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n");
#nullable restore
#line 127 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(150, "            ");
                __builder2.OpenElement(151, "p");
                __builder2.AddContent(152, "You\'re not signed in as a user in ");
                __builder2.AddContent(153, 
#nullable restore
#line 130 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
                                                  ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(154, ".");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n");
#nullable restore
#line 131 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(156, "\r\n    ");
            }
            ));
            __builder.AddAttribute(157, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(158, "\r\n        ");
                __builder2.AddMarkupContent(159, "<p>You\'re not loggged in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\OldUsers.razor"
       
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
    List<string> Options = new List<string>();  //Get the list of roles from the database

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
            ColIdentityRoles.Add(new IdentityRole { Id = item.Id, Name = item.Name });
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

    async Task DeleteUser(IdentityUser _IdentityUser)
    {
        // Delete the user
        await _UserManager.DeleteAsync(_IdentityUser);

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
