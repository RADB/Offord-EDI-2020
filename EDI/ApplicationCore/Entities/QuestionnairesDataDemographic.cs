﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Data.Demographics", Schema = "EDI")]
    public partial class QuestionnairesDataDemographic:BaseEntityQuestionnaire
    {
        public int ChildId { get; set; }        
        public byte? StudentStatus { get; set; }
        public byte? ClassAssignment { get; set; }
        public DateTime? Dob { get; set; }
        public byte? AttendedJk { get; set; }
        public byte? Jkteacher { get; set; }
        public byte? Gender { get; set; }
        public string PostalCode { get; set; }
        public byte? ClassType { get; set; }
        public byte? SpecialNeeds { get; set; }
        public byte? ConsideredEsl { get; set; }
        public byte? FrenchImmersion { get; set; }
        public byte? OtherImmersion { get; set; }
        public byte? EthnicStatus { get; set; }
        public byte? Communicates { get; set; }
        public bool? Chipewyan { get; set; }
        public bool? Cree { get; set; }
        public bool? English { get; set; }
        public bool? French { get; set; }
        public bool? Gwichin { get; set; }
        public bool? Inuinnaqtun { get; set; }
        public bool? Inuktitut { get; set; }
        public bool? Inuvialuktun { get; set; }
        public bool? NorthSlavey { get; set; }
        public bool? SouthSlavey { get; set; }
        public bool? Tlicho { get; set; }
        public byte? OtherLanguage { get; set; }
        public byte? LandAgreement { get; set; }

        public virtual Child Child { get; set; }
    }
}