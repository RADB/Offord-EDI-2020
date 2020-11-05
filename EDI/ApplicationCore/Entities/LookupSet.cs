﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("LookupSets", Schema = "LUData")]
    public partial class LookupSet:BaseEntity
    {
        public LookupSet()
        {
            LookupSetOptions = new HashSet<LookupSetOption>();
        }
        
        public int YearId { get; set; }
        public string LookupName { get; set; }
        
        public virtual Year Year { get; set; }
        public virtual ICollection<LookupSetOption> LookupSetOptions { get; set; }
    }
}