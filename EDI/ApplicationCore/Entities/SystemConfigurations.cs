using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public class SystemConfigurations : BaseEntity
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

    }
}
