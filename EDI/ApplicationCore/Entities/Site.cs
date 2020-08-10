﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Sites", Schema = "EDI")]
    public partial class Site:BaseEntity
    {
        public Site()
        {
            Schools = new HashSet<School>();
        }
        public string SiteNumber { get; set; }
        public int? YearId { get; set; }

        public string SiteName { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// guid from EDI.Identity.dbo.ASPNETUsers
        /// </summary>
        public string CoordinatorId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<School> Schools { get; set; }
        public virtual Year Year { get; set; }
    }
}