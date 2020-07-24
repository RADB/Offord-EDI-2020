using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class Province : BaseEntity
    {
        public Province()
        {
            Customers = new HashSet<Customers>();
            Customers1 = new HashSet<Customers>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int CountryID { get; set; }

        public int? ProvinceTypeId { get; set; }

        [Required]
        [StringLength(64)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(64)]
        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers1 { get; set; }

        public virtual ProvinceType ProvinceType { get; set; }
    }
}
