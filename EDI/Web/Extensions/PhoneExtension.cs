using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EDI.Web.Extensions
{
    public static class PhoneExtension
    {
        public static string ConvertPhone(string phonenumber)
        {
            string phone = string.Empty;

            if (!string.IsNullOrEmpty(phonenumber))
            {
                char[] numberarray = phonenumber.ToCharArray();

                foreach(char c in numberarray)
                {
                    if (Char.IsDigit(c))
                    {
                        phone = phone + c.ToString();
                    }
                }

                //phone = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
                string first3 = phone.Substring(0, 3);
                string middle3 = phone.Substring(3, 3);
                string last = phone.Substring(6);

                phone = first3 + "-" + middle3 + "-" + last;
            }
            

            return phone;
        }

        public static string ConvertTwilioMessageNumberFormat(string phonenumber)
        {
            string phone = string.Empty;

            if (!string.IsNullOrEmpty(phonenumber))
            {
                char[] numberarray = phonenumber.ToCharArray();

                foreach (char c in numberarray)
                {
                    if (Char.IsDigit(c))
                    {
                        phone = phone + c.ToString();
                    }
                }

                string first3 = phone.Substring(1, 3);
                string middle3 = phone.Substring(4, 3);
                string last = phone.Substring(7);

                phone = first3 + "-" + middle3 + "-" + last;
            }


            return phone;
        }

        public static string ConvertTwilioPhoneFormat(string phonenumber)
        {
            string phone = string.Empty;

            if (!string.IsNullOrEmpty(phonenumber))
            {
                char[] numberarray = phonenumber.ToCharArray();

                foreach (char c in numberarray)
                {
                    if (Char.IsDigit(c))
                    {
                        phone = phone + c.ToString();
                    }
                }
                
                string first3 = phone.Substring(1, 3);
                string middle3 = phone.Substring(4, 3);
                string last = phone.Substring(7);

                phone = "(" + first3 + ") " + middle3 + "-" + last;
            }


            return phone;
        }

        public static string ConvertPHRIPhoneFormat(string phonenumber)
        {
            string phone = string.Empty;

            if (!string.IsNullOrEmpty(phonenumber))
            {
                char[] numberarray = phonenumber.ToCharArray();

                foreach (char c in numberarray)
                {
                    if (Char.IsDigit(c))
                    {
                        phone = phone + c.ToString();
                    }
                }

                string first3 = phone.Substring(1, 3);
                string middle3 = phone.Substring(4, 3);
                string last = phone.Substring(7);

                phone = first3 + "-" + middle3 + "-" + last;
            }


            return phone;
        }
    }
}
