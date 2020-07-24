using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class Country : BaseEntity
    {
        public Country()
        {
            Customers = new HashSet<Customers>();
            Customers1 = new HashSet<Customers>();
            Province = new HashSet<Province>();
        }

        public int ISO3DigitCountry { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(2)]
        public string ISO2CountryCode { get; set; }

        [Required]
        [StringLength(3)]
        public string ISO3CountryCode { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(256)]
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(256)]
        public string ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Province> Province { get; set; }
    }
}
