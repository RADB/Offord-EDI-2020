using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Entities
{
    public partial class Customers : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Contact1 { get; set; }

        public string Contact2 { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int? CurrencyID { get; set; }

        public int? BillingCountryID { get; set; }

        public int? BillingProvinceID { get; set; }

        public string BillingAddress1 { get; set; }

        public string BillingAddress2 { get; set; }

        public string BillingCity { get; set; }

        [StringLength(50)]
        public string BillingPostal { get; set; }
        
        public bool? HasShippingAddress { get; set; }

        public string ShippingContact { get; set; }

        public int? ShippingCountryID { get; set; }

        public int? ShippingProvinceID { get; set; }

        public string ShippingAddress1 { get; set; }

        public string ShippingAddress2 { get; set; }

        public string ShippingCity { get; set; }

        [StringLength(50)]
        public string ShippingPostal { get; set; }

        [StringLength(50)]
        public string ShippingPhone { get; set; }

        public string DeliveryInstructions { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string TollFree { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        public string InternalNotes { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastSentDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Country Country { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Province Province { get; set; }

        public virtual Province Province1 { get; set; }
    }
}
