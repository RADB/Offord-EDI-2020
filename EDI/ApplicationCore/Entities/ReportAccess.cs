using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    public class ReportAccess
    {
        public string Schema { get; set; }
        public string ObjectName { get; set; }
        public string ParameterName { get; set; }
        public string ParameterDataType { get; set; }
        public string ParameterStringValue { get; set; }
        public int ParameterIntValue { get; set; }
    }
}
