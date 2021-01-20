using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class QuestionnaireItemViewModel : BaseModelProvince
    {
        [Required(ErrorMessage = "Year is required.")]
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        [Required(ErrorMessage = "Questionnaire Name is required.")]
        public string QuestionnaireName { get; set; }
        [Required(ErrorMessage = "English is required.")]
        public string English { get; set; }
        public string French { get; set; }
        public string DescriptionEnglish { get; set; }
        public string DescriptionFrench { get; set; }
        /// <summary>
        /// Answered x of y Questions
        /// </summary>
        public bool? ShowProgressBar { get; set; }
        public bool? ShowQuestionNumbers { get; set; }
    }
}
