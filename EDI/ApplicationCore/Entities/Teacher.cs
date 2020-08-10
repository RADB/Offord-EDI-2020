﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("Teachers", Schema = "EDI")]
    public partial class Teacher:BaseEntity
    {
        /// <summary>
        /// Links to user in EDI.Identity database
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Year of the EDI implementation
        /// </summary>
        public int? YearId { get; set; }
        public int? SchoolId { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte? Gender { get; set; }
        public byte? Age { get; set; }
        public byte? StudentCount { get; set; }
        public byte? FirstTimeCompletingEdi { get; set; }
        /// <summary>
        /// 1-4 or more
        /// </summary>
        public byte? TimesCompletedEdi { get; set; }
        public byte? PreviouslyAttendedTeacherTraining { get; set; }
        public byte? TimesAttendedTeacherTraining { get; set; }
        public byte? TeacherTrainingForThisImplementation { get; set; }
        public byte? TeacherTrainingUsefulness { get; set; }
        public byte? GuideUsedHelpful { get; set; }
        public byte? GuideUsedNotHelpful { get; set; }
        public byte? GuideNotUsedNotHelpful { get; set; }
        public byte? GuideNotUsedDidntHave { get; set; }
        public byte? GuideNotUsedNoTime { get; set; }
        public byte? GuideNotUsedFamiliar { get; set; }
        public byte? GuideOther { get; set; }
        public string GuideOtherComment { get; set; }
        public short? ExperienceInMonths { get; set; }
        public short? ExperienceSchoolInMonths { get; set; }
        public short? ExperienceGradeInMonths { get; set; }
        public short? ExperienceAtClassInMonths { get; set; }
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
        /// <summary>
        /// English or French
        /// </summary>
        public string LanguageCompleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual School School { get; set; }
        public virtual Year Year { get; set; }
    }
}