using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IQuestionnaireService
    {
        Task DeleteQuestionnaireAsync(int Id);
        Task DeleteQuestionnaireConfiguarionAsync(int Id);

        Task UpdateQuestionnaireAsync(QuestionnaireItemViewModel questionnaire);

        Task<int> CreateQuestionnaireAsync(QuestionnaireItemViewModel questionnaire);

        Task<QuestionnaireItemViewModel> GetQuestionnaireItem(int questionnaireId);

        Task<int> GetDuplicateCount(string name);
        Task<int> GetDuplicateCount(string name, int id);

        Task<QuestionnaireConfigurationItemViewModel> GetQuestionnaireConfigurationItem(int questionnaireConfigurationId);
        Task UpdateQuestionnaireConfigurationAsync(QuestionnaireConfigurationItemViewModel questionnaireConfiguration);
        Task<int> CreateQuestionnaireConfigurationAsync(QuestionnaireConfigurationItemViewModel questionnaireConfiguration);
        Task<int> GetQCDuplicateCount(string entityname, string entityfield);
        Task<int> GetQCDuplicateCount(string entityname, string entityfield, int id);
    }
}
