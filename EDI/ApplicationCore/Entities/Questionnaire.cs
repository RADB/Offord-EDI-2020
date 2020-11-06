using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires", Schema = "EDI")]
    public partial class Questionnaire:BaseEntity
    {
        public Questionnaire()
        {
            QuestionnairesConfigurations = new HashSet<QuestionnairesConfiguration>();
        }

        public int YearId { get; set; }
        public string QuestionnaireName { get; set; }
        public string English { get; set; }
        public string French { get; set; }
        public string DescriptionEnglish { get; set; }
        public string DescriptionFrench { get; set; }
        /// <summary>
        /// Answered x of y Questions
        /// </summary>
        public bool? ShowProgressBar { get; set; }
        public bool? ShowQuestionNumbers { get; set; }

        public virtual Year Year { get; set; }
        public virtual ICollection<QuestionnairesConfiguration> QuestionnairesConfigurations { get; set; }
    }
}