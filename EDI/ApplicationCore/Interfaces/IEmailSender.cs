using EDI.ApplicationCore.Models;
using System.Threading.Tasks;

namespace EDI.ApplicationCore.Interfaces
{

    public interface IEmailSender
    {
        Task<string> SendEmailAsync(EmailModel EmailModel);
    }
}
