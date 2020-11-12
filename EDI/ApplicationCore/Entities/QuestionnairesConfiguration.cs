﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires.Configuration", Schema = "EDI")]
    public partial class QuestionnairesConfiguration:BaseEntityProvinceConfiguration
    {
        public int QuestionnaireId { get; set; }
        public int InputTypeId { get; set; }
        public int? OrientationId { get; set; }
        public string QuestionNumber { get; set; }
        public bool? IsNewGroup { get; set; }
        public string GroupName { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        /// <summary>
        /// Variable Name for data dictionary
        /// </summary>
        public string VariableName { get; set; }
        public string EntityName { get; set; }
        public string EntityField { get; set; }
        public bool HasLookupEntity { get; set; }
        public string LookupEntity { get; set; }
        public int? LookupEntityId { get; set; }
        public bool RepeatHeader { get; set; }
        public bool IsRequired { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool IsConditional { get; set; }
        public string Condition { get; set; }
        public bool HasNotification { get; set; }
        public string NotificationCondition { get; set; }
        public string Notification { get; set; }
        public bool HasHelp { get; set; }
        public string HelpText { get; set; }
        public string Mask { get; set; }
        public byte? MaxLength { get; set; }
        public byte Columns { get; set; }
        public byte? ColumnSpan { get; set; }
       
        public int Sequence { get; set; }

        public virtual InputType InputType { get; set; }
        public virtual Orientation Orientation { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }        
    }
}