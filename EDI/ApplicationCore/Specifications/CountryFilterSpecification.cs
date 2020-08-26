using System;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class CountryFilterSpecification : BaseSpecification<Country>
    {
        public CountryFilterSpecification(int code, string name)
            : base(i => i.Code == code || i.English.ToLower() == name.Trim().ToLower())
        {
        }

        public CountryFilterSpecification(int code, string name, int id)
            : base(i => (i.Code == code || i.English.ToLower() == name.Trim().ToLower()) && i.Id != id)
        {
        }
    }
}
