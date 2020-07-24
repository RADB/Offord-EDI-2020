using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class FormConfigurations : BaseEntity
    {
        public string FormName { get; set; }

        public string FieldName { get; set; }

        public int Order { get; set; }

        public bool IsRequired { get; set; }

        public bool IsVisible { get; set; }

        public bool IsEnabled { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
