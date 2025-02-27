#pragma checksum "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b971190772fd9c9803f6d5e9bd01fee81a4f924"
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
#line 2 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration/roles")]
    public partial class Roles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administration - Roles</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(4, "            ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "\r\n                ");
                __builder2.AddMarkupContent(8, @"<thead>
                    <tr>
                        <th>Id</th>
                        <th>Role Name</th>
                        <th>Normalized Name</th>
                        <th>Concurrency</th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(9, "tbody");
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 22 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                     foreach (var role in ColRoles)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                    ");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "\r\n                        ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 25 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                             role.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(16, " ...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 26 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                             role.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 27 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                             role.NormalizedName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 28 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                             role.ConcurrencyStamp

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenElement(27, "td");
                __builder2.AddMarkupContent(28, "\r\n                            \r\n                            ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "class", "btn btn-primary");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                              (() => EditRole(role))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "\r\n                                Edit\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            \r\n                            ");
                __builder2.OpenElement(34, "button");
                __builder2.AddAttribute(35, "class", "btn btn-danger");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                              (() => DeleteRole(role))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(37, "\r\n                                Delete\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n");
#nullable restore
#line 42 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n");
#nullable restore
#line 45 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(44, "                \r\n                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "modal");
                __builder2.AddAttribute(47, "tabindex", "-1");
                __builder2.AddAttribute(48, "style", "display:block");
                __builder2.AddAttribute(49, "role", "dialog");
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "modal-dialog");
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "modal-content");
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "modal-header");
                __builder2.AddMarkupContent(59, "\r\n                                ");
                __builder2.AddMarkupContent(60, "<h3 class=\"modal-title\">Edit Role</h3>\r\n                                \r\n                                ");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "class", "close");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(65, "\r\n                                    ");
                __builder2.AddMarkupContent(66, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                            \r\n                            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "modal-body");
                __builder2.AddMarkupContent(71, "\r\n                                \r\n");
#nullable restore
#line 62 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                 if (objRole.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "                                    ");
                __builder2.OpenElement(73, "p");
                __builder2.AddContent(74, 
#nullable restore
#line 64 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                        objRole.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n");
#nullable restore
#line 65 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(76, "\r\n                                ");
                __builder2.OpenElement(77, "input");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "placeholder", "Name");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                              objRole.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objRole.Name = __value, objRole.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                ");
                __builder2.OpenElement(84, "input");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "type", "text");
                __builder2.AddAttribute(87, "placeholder", "Normalized Name");
                __builder2.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                              objRole.NormalizedName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objRole.NormalizedName = __value, objRole.NormalizedName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                                \r\n                                <br><br>\r\n                                \r\n                                ");
                __builder2.OpenElement(91, "button");
                __builder2.AddAttribute(92, "class", "btn btn-primary");
                __builder2.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                                  SaveRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(94, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                                \r\n");
#nullable restore
#line 81 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                 if (objRole.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(96, "                                    \r\n                                    ");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "class", "btn btn-danger");
                __builder2.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                                      DeleteRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(100, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n");
#nullable restore
#line 88 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(102, "                                <br>\r\n                                ");
                __builder2.OpenElement(103, "span");
                __builder2.AddAttribute(104, "style", "color:red");
                __builder2.AddContent(105, 
#nullable restore
#line 90 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                                         strError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n");
#nullable restore
#line 95 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(111, "            ");
                __builder2.OpenElement(112, "button");
                __builder2.AddAttribute(113, "class", "btn btn-success");
                __builder2.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                                      AddNewRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(115, "Add Role");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n");
#nullable restore
#line 97 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(117, "            ");
                __builder2.OpenElement(118, "p");
                __builder2.AddContent(119, "You\'re not signed in as a user in ");
                __builder2.AddContent(120, 
#nullable restore
#line 100 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
                                                  ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(121, ".");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n");
#nullable restore
#line 101 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(123, "    ");
            }
            ));
            __builder.AddAttribute(124, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(125, "\r\n        ");
                __builder2.AddMarkupContent(126, "<p>You\'re not loggged in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\andre\source\repos\Sources\BlazorUserRoles\BlazorUsersRoles\Pages\Administration\Roles.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    string ADMINISTRATION_ROLE = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    // Property used to add or edit the currently selected user
    IdentityUser objUser = new IdentityUser();

    // Property used to add or edit the currently selected user
    IdentityRole objRole= new IdentityRole();

    // Tracks the selected role for the currently selected user
    string CurrentUserRole { get; set; } = "Users";

    // Collection to display the existing users
    List<IdentityRole> ColRoles = new List<IdentityRole>();


    // To hold any possible errors
    string strError = "";

    // To enable showing the Popup
    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        // Get the current logged in user
        CurrentUser = (await authenticationStateTask).User;

        // get the roles
        GetRoles();
    }

    public void GetRoles()
    {
        // clear any error messages
        strError = "";

        // Collection to hold roles
        ColRoles = new List<IdentityRole>();

        // get roles from _RoleManager
        var role = _RoleManager.Roles.Select(x => new IdentityRole
        {
            Id = x.Id,
            Name = x.Name,
            NormalizedName = x.NormalizedName,
            ConcurrencyStamp = x.ConcurrencyStamp
        }) ;

        foreach (var item in role)
        {
            ColRoles.Add(item);
        }
    }
    void AddNewRole()
    {
        // Make new user
        objRole = new IdentityRole();

        // Set Id to blank so we know it is a new record
        objRole.Id = "";

        // Open the Popup
        ShowPopup = true;
    }


    async Task SaveRole()
    {
        try
        {
            // Is this an existing user?
            if (objRole.Id != "")
            {
                // Get the user
                var role = await _RoleManager.FindByIdAsync(objRole.Id);

                // Update Email
                role.Name= objRole.Name;

                // Update the user
                await _RoleManager.UpdateAsync(role);
            }
            else
            {
                // Insert new role

                var NewRole =
                    new IdentityRole
                    {
                        Name = objRole.Name,
                        NormalizedName = objRole.NormalizedName
                    };

                var CreateResult =
                    await _RoleManager
                    .CreateAsync(NewRole);

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
            }

            // Close the Popup
            ShowPopup = false;

            // Refresh Users
            GetRoles();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task EditRole(IdentityRole _IdentityRole)
    {
        // Set the selected role
        // as the current role
        objRole = _IdentityRole;

        // Get the role
        var role = await _RoleManager.FindByIdAsync(objRole.Id);

        // Open the Popup
        ShowPopup = true;
    }


    async Task DeleteRole()
    {
        try
        {
            // Close the Popup
            ShowPopup = false;

            // Get the user
            var role = await _RoleManager.FindByIdAsync(objRole.Id);
            if (role != null)
            {
                // Delete the user
                await _RoleManager.DeleteAsync(role);
            }

            // Refresh Roles
            GetRoles();
        }
        catch (Exception ex)
        {

        }
    }

    async Task DeleteRole(IdentityRole _IdentityRole)
    {
        try
        {
            // Delete the role
            await _RoleManager.DeleteAsync(_IdentityRole);

            // Refresh Roles
            GetRoles();
        }
        catch (Exception ex)
        {

        }
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
    }
}
#pragma warning restore 1591
