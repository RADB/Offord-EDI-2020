﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Years", Schema = "LUData")]
    public partial class Year:BaseEntityProvinceConfiguration
    {
        public Year()
        {
            // add lookupdata to the years
            Children = new HashSet<Child>();
            Coordinators = new HashSet<Coordinator>();
            Faqs = new HashSet<Faq>();
            InputTypes = new HashSet<InputType>(); 
            Links = new HashSet<Link>();
            LookupSets = new HashSet<LookupSet>();
            NewsFeeds = new HashSet<NewsFeed>();
            Orientations = new HashSet<Orientation>();
            Questionnaires = new HashSet<Questionnaire>();
            QuestionnairesConfigurations = new HashSet<QuestionnairesConfiguration>();
            QuestionnairesDataDemographics = new HashSet<QuestionnairesDataDemographic>();
            Schools = new HashSet<School>();
            Sites = new HashSet<Site>();
            TeacherFeedbackForms = new HashSet<TeacherFeedbackForm>();
            TeacherParticipationForms = new HashSet<TeacherParticipationForm>();
            Teachers = new HashSet<Teacher>();
        }
        public short? Ediyear { get; set; }

        public virtual ICollection<Child> Children { get; set; }
        public virtual ICollection<Coordinator> Coordinators { get; set; }
        public virtual ICollection<Faq> Faqs { get; set; }
        public virtual ICollection<InputType> InputTypes { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual ICollection<LookupSet> LookupSets { get; set; }
        public virtual ICollection<NewsFeed> NewsFeeds { get; set; }
        public virtual ICollection<Orientation> Orientations { get; set; }
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
        public virtual ICollection<QuestionnairesConfiguration> QuestionnairesConfigurations { get; set; }
        public virtual ICollection<QuestionnairesDataDemographic> QuestionnairesDataDemographics{ get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<TeacherFeedbackForm> TeacherFeedbackForms { get; set; }
        public virtual ICollection<TeacherParticipationForm> TeacherParticipationForms { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}