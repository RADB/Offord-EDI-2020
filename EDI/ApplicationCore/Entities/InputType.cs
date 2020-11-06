﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("InputTypes", Schema = "LUData")]
    public partial class InputType:BaseEntity
    {
        public InputType()
        {
            QuestionnairesConfigurations = new HashSet<QuestionnairesConfiguration>();
        }

        public int YearId { get; set; }
        public string English { get; set; }
        public string French { get; set; }

        public virtual Year Year { get; set; }
        public virtual ICollection<QuestionnairesConfiguration> QuestionnairesConfigurations { get; set; }
    }
}