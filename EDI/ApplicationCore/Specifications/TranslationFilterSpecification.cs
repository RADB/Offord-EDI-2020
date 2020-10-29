using System;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class TranslationFilterSpecification : BaseSpecification<Translation>
    {
        public TranslationFilterSpecification(string english)
            : base(i => i.English.ToLower().Trim() == english.ToLower().Trim())
        {
        }

        public TranslationFilterSpecification(string english, int id)
            : base(i => i.English.ToLower().Trim() == english.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
