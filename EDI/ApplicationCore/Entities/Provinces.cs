using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    public partial class Provinces : BaseEntity
    {
        public Provinces()
        {
            Schools = new HashSet<Schools>();
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

        public virtual Countries Country { get; set; }

        public virtual ProvinceType ProvinceType { get; set; }
        public virtual ICollection<Schools> Schools { get; set; }
    }
}
