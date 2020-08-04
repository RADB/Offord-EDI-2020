using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Sites", Schema = "EDI")]
    public partial class Site : BaseEntity
    {
        [Required]
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// guid from EDI.Identity.dbo.ASPNETUsers
        /// </summary>
        public string CoordinatorId { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}