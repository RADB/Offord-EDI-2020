using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class EDIAppSettings
    {
        public string EmailHost { get; set; }

        public string EmailFrom { get; set; }

        public string EmailSubject { get; set; }

        public string EmailTo { get; set; }

        public string EmailToServiceDesk { get; set; }

        public string Recipient { get; set; }

        public string URL { get; set; }

        public string Host { get; set; }

        public string Cc1Email { get; set; }

        public string Cc1Name { get; set; }

        public string ClientID { get; set; }

        public string ImpersonatedUserGuid { get; set; }

        public string AuthServer { get; set; }

    }
}
