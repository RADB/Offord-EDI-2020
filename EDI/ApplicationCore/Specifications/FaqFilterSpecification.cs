using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class FaqFilterSpecification : BaseSpecification<Faq>
    {
        public FaqFilterSpecification(string question)
            : base(i => i.Question.ToLower().Trim() == question.ToLower().Trim())
        {
        }

        public FaqFilterSpecification(string question, int id)
            : base(i => i.Question.ToLower().Trim() == question.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
