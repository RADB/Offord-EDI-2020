using System;
using System.Threading.Tasks;
using Blazored.Modal.Services;
using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Models;
using EDI.Infrastructure.Data;
using EDI.Infrastructure.Identity;
using EDI.Web.Extensions;
using EDI.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq;
using Microsoft.AspNetCore.Components.Authorization;
using EDI.Web.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Web.Controllers
{
    public class SignInController : Controller
    {
        private readonly UserManager<EDIApplicationUser> _userManager;
        private readonly SignInManager<EDIApplicationUser> _signInManager;
        private IModalService _modal;
        private readonly IEmailSender _emailSender;
        private EDIAppSettings EDIAppSettings { get; set; }
        private readonly ServiceContext _dbContext;
        private readonly AppIdentityDbContext _identityContext;
        private readonly ISharedService _sharedService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SignInController(
            UserManager<EDIApplicationUser> userManager,
            SignInManager<EDIApplicationUser> signInManager,
            IEmailSender emailSender,
            ISharedService sharedService,
            IOptions<EDIAppSettings> settings,
            ServiceContext dbContext,
            AppIdentityDbContext identityContext,
            IHttpContextAccessor httpContextAccessor,
            IModalService modal)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _modal = modal;
            _emailSender = emailSender;
            EDIAppSettings = settings.Value;
            _dbContext = dbContext;
            _identityContext = identityContext;
            _sharedService = sharedService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost("/signin")]
        public async Task<IActionResult> Login([FromForm] string username, [FromForm] string password)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(username, password, false, false);

                if (!result.Succeeded)
                {
                    return Redirect("/");
                }
                else
                {
                    var user1 = _identityContext.Users.Where(p => p.UserName == username).FirstOrDefault();
                    var userrole = _identityContext.UserRoles.Where(p => p.UserId == user1.Id).FirstOrDefault();

                    var role = _identityContext.Roles.Where(p => p.Id == userrole.RoleId).FirstOrDefault();


                    if (role.Name == "Teacher")
                    {
                        var teacher = await Task.FromResult(_dbContext.Teachers.Where(s => s.UserId == user1.Id).FirstOrDefault());

                        if (teacher == null)
                        {
                            await Logout();
                            return Redirect("./LoginError/This teacher account doesnt exist.");
                        }
                        else
                        {
                            // TODO get user role and load statemanager here - send error back to user so they know what is going on
                            return Redirect("./Dashboard/index");
                        }
                    }
                    else
                    {
                        // TODO get user role and load statemanager here - send error back to user so they know what is going on
                        return Redirect("./Dashboard/index");
                    }                    
                }
            }
            catch (Exception ex)
            {
                //_modal.Show<FA.Web.Shared.ErrorWindow>("Error");
                return Redirect("./LoginError/" + ex.Message);
            }
        }

        [HttpPost("/signout")]
        public async Task<IActionResult> Logout()
        {
            //var username = _httpContextAccessor.HttpContext.User.Identity.Name;
            //if (!string.IsNullOrEmpty(username))
            //{
            //    var user = _identityContext.Users.Where(p => p.UserName == username).FirstOrDefault();
            //    await _sharedService.DeleteUserSessions(user.Id);
            //}

            await _signInManager.SignOutAsync();
            return Redirect("./");
        }

        [HttpPost("/forgotpassword")]
        public async Task<IActionResult> ForgotPassword([FromForm] string email)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    return Redirect("/");
                }
                else
                {
                    var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var callbackUrl = EDIAppSettings.Host + "Accounts/ResetPassword/resetpassword";
                    string useremail = !string.IsNullOrEmpty(user.UserName) ? user.UserName : user.Email;
                    EmailModel emailmodel = new EmailModel();
                    emailmodel.From = EDIAppSettings.EmailFrom;
                    emailmodel.To = useremail;
                    emailmodel.Subject = "Reset Password";
                    emailmodel.Body = $"Please click <a href='{callbackUrl}'>here</a> to reset your password.";
                     await _emailSender.SendEmailAsync(emailmodel);

                    return Redirect("./Login");
                }
            }
            catch (Exception ex)
            {
                //_modal.Show<FA.Web.Shared.ErrorWindow>("Error");
                return Redirect("./LoginError/" + ex.Message);
            }
        }


        [HttpPost("/resetpassword")]
        public async Task<IActionResult> ResetPassword([FromForm] string username, [FromForm] string password, [FromForm] string confirmpassword)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(username);

                var message = string.Empty;

                if (user == null)
                {
                    message = "Email is invalid.";
                    return Redirect("/Accounts/ResetPassword/"+ message);
                }
                else
                {
                    if (string.IsNullOrEmpty(password))
                    {
                        message = "Password is invalid.";
                        return Redirect("/Accounts/ResetPassword/" + message);
                    }
                    else if (string.IsNullOrEmpty(confirmpassword))
                    {
                        message = "Confirm Password is invalid.";
                        return Redirect("/Accounts/ResetPassword/" + message);
                    }
                    else if(!password.Equals(confirmpassword))
                    {
                        message = "The password and confirmation password do not match.";
                        return Redirect("/Accounts/ResetPassword/" + message);
                    }
                    else if (!ValidateExtension.IsPasswordValid(password))
                    {
                        message = "Password Rules: Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character.";
                        return Redirect("/Accounts/ResetPassword/" + message);
                    }
                    else
                    {
                        var newPassword = _userManager.PasswordHasher.HashPassword(user, password);
                        user.PasswordHash = newPassword;
                        var result = await _userManager.UpdateAsync(user);

                        if (result.Succeeded)
                        {
                            return Redirect("/Login");
                        }
                        else
                        {
                            message = "Internal Error. Please contact administrator.";
                            return Redirect("/Accounts/ResetPassword/" + message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //_modal.Show<FA.Web.Shared.ErrorWindow>("Error");
                return Redirect("./Accounts/ResetPassword/" + ex.Message);
            }
        }
    }
}