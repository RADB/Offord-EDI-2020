using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class Countries : BaseEntity
    {
        public Countries()
        {
            Provinces = new HashSet<Provinces>();
            Schools = new HashSet<Schools>();
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
        public virtual ICollection<Provinces> Provinces { get; set; }
        public virtual ICollection<Schools> Schools { get; set; }
    }
}
