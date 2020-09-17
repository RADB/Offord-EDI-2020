using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;

namespace EDI.Web.Models
{
    public class ErrorViewModel
    {
        public string message { get; set; }

        public List<string> messages { get; set; }

        public List<string> errormessages { get; set; }

        public string errormessage { get; set; }

        public int? itemcount { get; set; }
    }
}