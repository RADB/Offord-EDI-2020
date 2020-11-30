using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class QuestionnaireFilterSpecification : BaseSpecification<Questionnaire>
    {
        public QuestionnaireFilterSpecification(string name)
            : base(i => i.QuestionnaireName.ToLower().Trim() == name.ToLower().Trim())
        {
        }

        public QuestionnaireFilterSpecification(string name, int id)
            : base(i => i.QuestionnaireName.ToLower().Trim() == name.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
