﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Data.SectionA", Schema = "EDI")]
    public partial class QuestionnairesDataSectionA:BaseEntityQuestionnaire
    {
        public int ChildId { get; set; }
        public decimal Days { get; set; }
        public byte UnderDressed { get; set; }
        public byte Tired { get; set; }
        public byte Late { get; set; }
        public byte Hungry { get; set; }
        public byte WashroomHabits { get; set; }
        public byte HandPreference { get; set; }
        public byte Coordinated { get; set; }
        public byte Holding { get; set; }
        public byte Manipulating { get; set; }
        public byte ClimbingStairs { get; set; }
        public byte Energy { get; set; }
        public byte PhysicalDevelopment { get; set; }

        public virtual Child Child { get; set; }
    }
}