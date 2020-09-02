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
        public Teacher()
        {
            Children = new HashSet<Child>();
            TeacherParticipationForms = new HashSet<TeacherParticipationForm>();
        }

        /// <summary>
        /// Links to user in EDI.Identity database
        /// </summary>
        public string UserId { get; set; }
        public string TeacherNumber { get; set; }
        /// <summary>
        /// Year of the EDI implementation
        /// </summary>
        public int? YearId { get; set; }
        public int? SchoolId { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual School School { get; set; }
        public virtual Year Year { get; set; }
        public virtual ICollection<Child> Children { get; set; }
        public virtual ICollection<TeacherParticipationForm> TeacherParticipationForms { get; set; }
    }
}