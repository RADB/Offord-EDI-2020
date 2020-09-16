﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("TeacherFeedbackForms", Schema = "EDI_Forms")]
    public partial class TeacherFeedbackForm:BaseEntityQuestionnaire
    {        
        public int TeacherId { get; set; }
        /// <summary>
        /// Year of the EDI implementation
        /// </summary>
        public int? YearId { get; set; }
        public byte? FirstTimeCompletingEdi { get; set; }
        public byte? CompletedPaperVersion { get; set; }
        public byte? VersionPreferred { get; set; }
        public byte? FirstTraining { get; set; }
        public byte? MaterialsVideo { get; set; }
        public byte? MaterialsGuestSpeaker { get; set; }
        public byte? MaterialsHistory { get; set; }
        public byte? MaterialsPastEdi { get; set; }
        public byte? MaterialsTrainingInComputerLab { get; set; }
        public byte? MaterialsTimeToStart { get; set; }
        public byte? MaterialsPpt { get; set; }
        public byte? MaterialsOther { get; set; }
        public string MaterialsOtherSpecify { get; set; }
        public byte? ContentRelevant { get; set; }
        public byte? ContentQualityPresentations { get; set; }
        public byte? ContentClearlyPresented { get; set; }
        public byte? ContentUsefulnessOfHandouts { get; set; }
        public byte? ProcessOrganization { get; set; }
        public byte? ProcessQuestions { get; set; }
        public byte? ProcessDiscussion { get; set; }
        public byte? ProcessInteration { get; set; }
        public byte? OverallAssessment { get; set; }
        public string MostBeneficial { get; set; }
        public string CommentsFeedback { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Year Year { get; set; }
    }
}