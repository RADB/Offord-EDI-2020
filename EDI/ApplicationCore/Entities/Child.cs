﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace EDI.ApplicationCore.Entities
{
    public partial class Child:BaseEntity
    {        
        public string Ediid { get; set; }
        public string LocalId { get; set; }
        /// <summary>
        /// Year of the EDI implementation
        /// </summary>
        public int? YearId { get; set; }
        public int? TeacherId { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Dob { get; set; }
        public string PostalCodeZip { get; set; }

        public virtual Gender Genders { get; set; }
        public virtual Teacher Teachers { get; set; }
        public virtual Year Years { get; set; }
    }
}