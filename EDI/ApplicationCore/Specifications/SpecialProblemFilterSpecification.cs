using System;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class SpecialProblemFilterSpecification : BaseSpecification<SpecialProblem>
    {
        public SpecialProblemFilterSpecification(string code)
            : base(i => i.SpecialProblemCode.ToLower().Trim() == code.ToLower().Trim())
        {
        }

        public SpecialProblemFilterSpecification(string code, int id)
            : base(i => i.SpecialProblemCode.ToLower().Trim() == code.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
