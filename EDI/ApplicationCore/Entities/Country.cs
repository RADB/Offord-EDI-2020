using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Countries", Schema = "LUData")]
    public partial class Country : BaseEntity
    {
        public Country()
        {
            Provinces = new HashSet<Province>();
            Schools = new HashSet<School>();
        }
        /// <summary>
        /// ISO3DigitCountry
        /// </summary>
        public int Code { get; set; }

        public int? YearId { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Province> Provinces { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual Year Year { get; set; }
    }
}
