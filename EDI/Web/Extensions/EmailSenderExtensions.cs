using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Models;
using EDI.Web.Models;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace EDI.Web.Extensions
{
    public static class EmailSenderExtensions
    {
        public static async Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link, string firstName)
        {            
            string htmlString = string.Format(@"<html>
                      <body>
                      <p>Dear {0},</p>
                      <p>This email is to confirm that your account for the EDI has been successfully created.</p>", firstName);
            string callbackUrl = "http://localhost:63970/Accounts/ResetPassword/resetpassword";
            string htmlString2 = $"Please click <a href='{callbackUrl}'>here</a> to reset your password. Your login user name is your current email:" + email;
            //string htmlString2 = $"<p>Please navigate to <a href='{HtmlEncoder.Default.Encode(link)}'>http://localhost:63970/Accounts/ResetPassword/resetpassword</a> to set your password.</p>";
            string htmlString3 = @"<p>Please let us know if you have any questions or concerns.</p> 
                      <p>Thank you!<br><br>EDI<br />webmaster@e-edi.ca</p>
                      </body>
                      </html>";
            string htmlString4 = htmlString + htmlString2 + htmlString3;

            EmailModel emailmodel = new EmailModel();
            emailmodel.From = "webmaster@e-edi.ca";
            emailmodel.To = email;
            emailmodel.Subject = "Confirm your email";
            emailmodel.Body = htmlString4;
            await emailSender.SendEmailAsync(emailmodel);
        }
    }
}
