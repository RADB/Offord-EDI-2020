﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Data.TeacherProfile", Schema = "EDI")]
    public partial class QuestionnairesDataTeacherProfile:BaseEntityQuestionnaire
    { 
        public int TeacherId { get; set; }
        public byte? FirstTimeCompletingEdi { get; set; }
        /// <summary>
        /// 1-4 or more
        /// </summary>
        public byte? TimesCompletedEdi { get; set; }
        public byte? PreviouslyAttendedTeacherTraining { get; set; }
        public byte? TimesAttendedTeacherTraining { get; set; }
        public byte? TeacherTrainingForThisImplementation { get; set; }
        public byte? TeacherTrainingUsefulness { get; set; }
        public byte? GuideUsefulness { get; set; }

        public string GuideOtherComment { get; set; }

        public byte? Gender { get; set; }
        public byte? AgeCategory { get; set; }

        public short? ExperienceInYears { get; set; }
        public short? ExperienceSchoolInYears { get; set; }
        public short? ExperienceGradeInYears { get; set; }
        public byte? EducationSomeCoursesBachelors { get; set; }
        public byte? EducationTeachingCertificate { get; set; }
        public byte? EducationBachelorDegree { get; set; }
        public byte? EducationBachelorEducationDegree { get; set; }
        public byte? EducationPostBachelorCourses { get; set; }
        public byte? EducationPostBachelorCertificate { get; set; }
        public byte? EducationMastersCourses { get; set; }
        public byte? EducationMastersDegree { get; set; }
        public byte? EducationPhdcourses { get; set; }
        public byte? EducationPhd { get; set; }
        public byte? EducationOther { get; set; }
        public string EducationOtherComment { get; set; }

        public virtual Teacher Teacher{ get; set; }        

    }
}