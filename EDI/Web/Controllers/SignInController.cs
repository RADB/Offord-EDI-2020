using System;
using System.Threading.Tasks;
using Blazored.Modal.Services;
using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Models;
using EDI.Infrastructure.Identity;
using EDI.Web.Extensions;
using EDI.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Web.Controllers
{
    public class SignInController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private IModalService _modal;
        private readonly IEmailSender _emailSender;
        private EDIAppSettings EDIAppSettings { get; set; }

        public SignInController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            IOptions<EDIAppSettings> settings,
            IModalService modal)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _modal = modal;
            _emailSender = emailSender;
            EDIAppSettings = settings.Value;
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
                    return Redirect("./Dashboard/index");
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