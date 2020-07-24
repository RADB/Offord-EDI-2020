using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class Currency : BaseEntity
    {
        public Currency()
        {
            Customers = new HashSet<Customers>();
        }

        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
