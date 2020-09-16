﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Coordinators", Schema = "EDI")]
    public partial class Coordinator:BaseEntity
    {
        public Coordinator()
        {
            Sites = new HashSet<Site>();
        }
        public string UserId { get; set; }
        /// <summary>
        /// Year of the EDI implementation
        /// </summary>
        public int? YearId { get; set; }
        public string CoordinatorName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual Year Year { get; set; }
    }
}