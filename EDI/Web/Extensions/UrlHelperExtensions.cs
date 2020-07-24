using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace EDI.Web.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(SignInController.ResetPassword),
                controller: "SignIn",
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
