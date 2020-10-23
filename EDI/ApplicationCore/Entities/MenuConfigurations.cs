using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class MenuConfigurations : BaseEntity
    {
        public string NodeId { get; set; }

        public string English { get; set; }

        public string French { get; set; }

        public string URL { get; set; }

        public string IconCss { get; set; }

        public bool ForAdmin { get; set; }

        public bool ForTeacher { get; set; }

        public bool ForCoordinator { get; set; }

        public bool IsVisible { get; set; }

        public bool HasChild { get; set; }

        public string PID { get; set; }

        public int DisplayOrder { get; set; }
    }
}
