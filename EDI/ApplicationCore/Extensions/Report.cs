using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Extensions
{
    public class Report
    {
        public Report()
        {
            Parameters = new HashSet<Parameter>();
        }
        public string Schema { get; set; }
        public string ObjectName { get; set; }
        public virtual ICollection<Parameter> Parameters { get; set; }
    }

    public class Parameter
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public DateTime DateValue { get; set; }
    }
}
