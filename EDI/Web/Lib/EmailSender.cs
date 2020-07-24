using EDI.ApplicationCore.Interfaces;
using EDI.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Net.Mail;
using System.Threading.Tasks;
using EDI.ApplicationCore.Models;
using Microsoft.AspNetCore.Components.Authorization;
using EDI.Infrastructure.Identity;
using System.Linq;

namespace EDI.Web.Lib
{
    public class EmailSender : IEmailSender
    {
        private EDIAppSettings POAppSettings { get; set; }
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly AppIdentityDbContext _dbIdentityContext;

        public EmailSender(
            AuthenticationStateProvider authenticationStateProvider,
            AppIdentityDbContext dbIdentityContext,
            IOptions<EDIAppSettings> settings)
        {
            POAppSettings = settings.Value;
            _dbIdentityContext = dbIdentityContext;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<string> SendEmailAsync(EmailModel EmailModel)
        {
            // TODO: Wire this up to actual email sending logic via SendGrid, local SMTP, etc.
            //return Task.CompletedTask;

            string message = string.Empty;
            try
            {
                var mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(EmailModel.From);
                mailMessage.To.Add(EmailModel.To);
                mailMessage.IsBodyHtml = true;
                mailMessage.Subject = EmailModel.Subject;
                mailMessage.Body = EmailModel.Body;
                if(EmailModel.UseAttachment.HasValue && EmailModel.UseAttachment.Value)
                    mailMessage.Attachments.Add(new Attachment(EmailModel.Attachment));
                if(EmailModel.SendCopyToSelf.HasValue && EmailModel.SendCopyToSelf.Value)
                {
                    var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
                    var user = authState.User;

                    var currentuser = _dbIdentityContext.Users.Where(p => p.DisplayName == user.Identity.Name).FirstOrDefault();
                    mailMessage.Bcc.Add(currentuser.Email); 
                }
                using (var smtpClient = new SmtpClient(POAppSettings.EmailHost))
                {
                    smtpClient.UseDefaultCredentials = true;
                    await smtpClient.SendMailAsync(mailMessage);
                }

                message = "Sent.";

                return message;
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                //throw new InvalidOperationException(ex.Message);
                return ex.Message;
            }
        }
    }
}
