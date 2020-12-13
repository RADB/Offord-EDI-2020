using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class QuestionnaireConfigurationFilterSpecification : BaseSpecification<QuestionnairesConfiguration>
    {
        public QuestionnaireConfigurationFilterSpecification(string entityname, string entityfield)
            : base(i => i.EntityName.ToLower().Trim() == entityname.ToLower().Trim() && i.EntityField.ToLower().Trim() == entityfield.ToLower().Trim())
        {
        }

        public QuestionnaireConfigurationFilterSpecification(string entityname, string entityfield, int id)
            : base(i => i.EntityName.ToLower().Trim() == entityname.ToLower().Trim() && i.EntityField.ToLower().Trim() == entityfield.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
