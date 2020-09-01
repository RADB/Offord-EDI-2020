using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Provinces", Schema = "LUData")]
    public partial class Province : BaseEntity
    {
        public Province()
        {            
            Schools = new HashSet<School>();
        }
        [Required]
        [StringLength(100)]
        public string English { get; set; }
        public string French { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int CountryID { get; set; }

        public int? ProvinceTypeId { get; set; }

        public virtual Country Countries { get; set; }

        public virtual ProvinceType ProvinceTypes { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}
