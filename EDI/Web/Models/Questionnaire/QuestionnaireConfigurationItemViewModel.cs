using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class QuestionnaireConfigurationItemViewModel : BaseModelProvince
    {
        public int QuestionnaireId { get; set; }

        [Required(ErrorMessage = "Input Type is required.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Input Type is required.")]
        public int InputTypeId { get; set; }
        public string InputType { get; set; }
        public int? OrientationId { get; set; }
        public string Orientation { get; set; }
        public string QuestionNumber { get; set; }
        public bool IsHeader { get; set; }
        public bool ShowGroupName { get; set; }
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
        public bool IsRequired { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsCollapsible { get; set; }
        public bool? IsConditional { get; set; }
        public string Condition { get; set; }
        public bool? HasNotification { get; set; }
        public string NotificationCondition { get; set; }
        public string Notification { get; set; }
        public string NotificationFrench { get; set; }
        public bool HasHelp { get; set; }
        public string HelpTextEnglish { get; set; }
        public string HelpTextFrench { get; set; }
        public string Mask { get; set; }
        public byte? MaxLength { get; set; }
        public byte Columns { get; set; }
        public byte? ColumnSpan { get; set; }
        public int Sequence { get; set; }
        public int? YearId { get; set; }
        public short? Ediyear { get; set; }
    }
}
