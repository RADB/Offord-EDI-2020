using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.ApplicationCore.Models
{
    public class EmailModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Attachment { get; set; }

        public string Message { get; set; }

        public string ErrorMessage { get; set; }


        public bool? UseAttachment { get; set; }
        public bool? SendCopyToSelf { get; set; }
    }
}
