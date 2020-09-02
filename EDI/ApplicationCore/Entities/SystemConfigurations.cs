using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("SystemConfigurations", Schema = "dbo")]
    public class SystemConfigurations : BaseEntity
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }
    }
}
