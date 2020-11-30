﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("LookupSetOptions", Schema = "LUData")]
    public partial class LookupSetOption:BaseEntity
    {       
        //public int YearId { get; set; }
        public int LookupSetId { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public byte Value { get; set; }
        public short Sequence { get; set; }

        public virtual LookupSet LookupSet { get; set; }
    }
}