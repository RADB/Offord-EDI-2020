using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("CustomerAccess")]
    public partial class CustomerAccess : BaseEntity
    {
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Contact { get; set; }

        public string Contact1 { get; set; }

        public string Contact2 { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int? CurrencyID { get; set; }

        public string Currency { get; set; }

        public int? BillingCountryID { get; set; }

        [StringLength(100)]
        public string BillingCountry { get; set; }

        public int? BillingProvinceID { get; set; }

        [StringLength(100)]
        public string BillingProvince { get; set; }

        public string BillingAddress1 { get; set; }

        public string BillingAddress2 { get; set; }

        public string BillingCity { get; set; }

        [StringLength(50)]
        public string BillingPostal { get; set; }

        public bool? HasShippingAddress { get; set; }

        public string ShippingContact { get; set; }

        public int? ShippingCountryID { get; set; }

        [StringLength(100)]
        public string ShippingCountry { get; set; }

        public int? ShippingProvinceID { get; set; }

        [StringLength(100)]
        public string ShippingProvince { get; set; }

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

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
