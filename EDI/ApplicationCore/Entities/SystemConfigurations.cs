using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public class SystemConfigurations : BaseEntity
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
