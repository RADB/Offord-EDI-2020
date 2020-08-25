using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class Country : BaseEntity
    {
        public Country()
        {
            Provinces = new HashSet<Province>();
            Schools = new HashSet<School>();
        }

        public int ISO3DigitCountry { get; set; }

        [Required]
        [StringLength(100)]
        public string English { get; set; }
        public string French { get; set; }

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
        public virtual ICollection<Province> Provinces { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}
