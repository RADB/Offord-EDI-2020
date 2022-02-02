using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class FaqFilterSpecification : BaseSpecification<Faq>
    {
        public FaqFilterSpecification(string question, int yearid)
            : base(i => i.Question.ToLower().Trim() == question.ToLower().Trim() && i.YearId == yearid)
        {
        }

        public FaqFilterSpecification(string question, int yearid, int id)
            : base(i => i.Question.ToLower().Trim() == question.ToLower().Trim() && i.YearId == yearid && i.Id != id)
        {
        }
    }
}
