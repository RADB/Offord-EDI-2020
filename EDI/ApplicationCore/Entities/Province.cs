﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Provinces", Schema = "LUData")]
    public partial class Province : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string English { get; set; }
        public string French { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int CountryID { get; set; }

        public int? ProvinceTypeId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ProvinceType ProvinceType { get; set; }
    }
}
