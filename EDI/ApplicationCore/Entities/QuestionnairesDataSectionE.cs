﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Data.SectionE", Schema = "EDI")]
    public partial class QuestionnairesDataSectionE:BaseEntityQuestionnaire
    {
        public int ChildId { get; set; }
        public byte Birth1 { get; set; }
        public byte One2 { get; set; }
        public byte Two3 { get; set; }
        public byte Three4 { get; set; }
        public byte Four5 { get; set; }
        public byte FamilyLiteracy { get; set; }
        public byte FamilyResource { get; set; }
        public byte LibraryReading { get; set; }
        public byte MusicArts { get; set; }
        public byte Sports { get; set; }
        public byte Clubs { get; set; }
        public byte Cultural { get; set; }
        public byte Langauges { get; set; }
        public byte Religion { get; set; }
        public byte Other { get; set; }
        public byte OtherSpecify { get; set; }
        public string Comments { get; set; }

        public virtual Child Child { get; set; }        
    }
}