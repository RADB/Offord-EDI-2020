﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Data.SectionD", Schema = "EDI")]
    public partial class QuestionnairesDataSectionD:BaseEntityQuestionnaire
    {
        public int ChildId { get; set; }
        public byte? Problem { get; set; }
        public byte? Physical { get; set; }
        public byte? Visual { get; set; }
        public byte? Hearing { get; set; }
        public byte? Speech { get; set; }
        public byte? Learning { get; set; }
        public byte? Emotional { get; set; }
        public byte? Behavioural { get; set; }
        public byte? Language { get; set; }
        public byte? Chronic { get; set; }
        public byte? Dental { get; set; }
        public byte? Other { get; set; }
        public string OtherSpecify { get; set; }
        public byte? SpecialProblem1 { get; set; }
        public byte? SpecialProblem2 { get; set; }
        public byte? SpecialProblem3 { get; set; }
        public string OtherSpecialProblem { get; set; }
        public byte? Support { get; set; }
        public byte? Further { get; set; }
        public byte? WaitList { get; set; }
        public byte? NeedsAssess { get; set; }
        public string AssessSpecify { get; set; }
        [JsonIgnore]
        public virtual Child Child { get; set; }
        [JsonIgnore]
        public virtual Questionnaire Questionnaire { get; set; }

    }
}