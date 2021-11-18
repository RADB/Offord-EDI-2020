﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Genders", Schema = "LUData")]
    public partial class Gender:BaseEntity
    {
        public Gender()
        {
            Children = new HashSet<Child>();
            FileImports = new HashSet<FileImport>();
            QuestionnairesDataDemographics = new HashSet<QuestionnairesDataDemographic>();
            // TeacherParticipationForms = new HashSet<TeacherParticipationForm>();
        }
        public int? YearId { get; set; }
        public string Code { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<Child> Children { get; set; }
        public virtual ICollection<FileImport> FileImports { get; set; }
        public virtual ICollection<QuestionnairesDataDemographic> QuestionnairesDataDemographics { get; set; }

        public virtual Year Year { get; set; }
        //public virtual ICollection<TeacherParticipationForm> TeacherParticipationForms{ get; set; }
    }
}
