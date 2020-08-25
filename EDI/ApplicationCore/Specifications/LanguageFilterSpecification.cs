using System;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class LanguageFilterSpecification : BaseSpecification<Language>
    {
        public LanguageFilterSpecification(string code)
            : base(i => i.Code.ToLower().Trim() == code.ToLower().Trim())
        {
        }

        public LanguageFilterSpecification(string code, int id)
            : base(i => i.Code.ToLower().Trim() == code.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
