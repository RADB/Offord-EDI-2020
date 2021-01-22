using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EDI.ApplicationCore.Entities
{
    [Table("Questionnaires", Schema = "EDI")]
    public partial class Questionnaire:BaseEntityProvinceConfiguration
    {
        public Questionnaire()
        {
            QuestionnairesConfigurations = new HashSet<QuestionnairesConfiguration>();
            QuestionnairesDataDemographics = new HashSet<QuestionnairesDataDemographic>();
            QuestionnairesDataSectionAs = new HashSet<QuestionnairesDataSectionA>();
            QuestionnairesDataSectionBs = new HashSet<QuestionnairesDataSectionB>();
            QuestionnairesDataSectionCs = new HashSet<QuestionnairesDataSectionC>();
            QuestionnairesDataSectionDs = new HashSet<QuestionnairesDataSectionD>();
            QuestionnairesDataSectionEs = new HashSet<QuestionnairesDataSectionE>();
            QuestionnairesDataTeacherProfiles = new HashSet<QuestionnairesDataTeacherProfile>();
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
        public string EntityName { get; set; }
        public bool? ShowQuestionNumbers { get; set; }
        public int Sequence { get; set; } 
        public bool IsChildQuestionnaire { get; set; }
        public bool IsTeacherQuestionnaire { get; set; } 
        public int QuestionsRequired { get; set; }
        public virtual Year Year { get; set; }
        public virtual ICollection<QuestionnairesConfiguration> QuestionnairesConfigurations { get; set; }
        public virtual ICollection<QuestionnairesDataDemographic> QuestionnairesDataDemographics { get; set; }
        public virtual ICollection<QuestionnairesDataSectionA> QuestionnairesDataSectionAs { get; set; }
        public virtual ICollection<QuestionnairesDataSectionB> QuestionnairesDataSectionBs { get; set; }
        public virtual ICollection<QuestionnairesDataSectionC> QuestionnairesDataSectionCs { get; set; }
        public virtual ICollection<QuestionnairesDataSectionD> QuestionnairesDataSectionDs { get; set; }
        public virtual ICollection<QuestionnairesDataSectionE> QuestionnairesDataSectionEs { get; set; }
        public virtual ICollection<QuestionnairesDataTeacherProfile> QuestionnairesDataTeacherProfiles { get; set; }
    }
}