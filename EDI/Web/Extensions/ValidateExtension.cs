using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EDI.Web.Extensions
{
    public static class ValidateExtension
    {
        public static bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsPasswordValid(string password)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
                //Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character
                Match match = regex.Match(password);
                if (match.Success)
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
