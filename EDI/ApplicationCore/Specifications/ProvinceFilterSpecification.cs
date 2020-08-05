using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class ProvinceFilterSpecification : BaseSpecification<Provinces>
    {
        public ProvinceFilterSpecification(int countryid)
            : base(i => i.CountryID == countryid
            )
        {
        }

        public ProvinceFilterSpecification(int countryid, string name)
            : base(i => i.CountryID == countryid && i.Name == name)
        {
        }

        public ProvinceFilterSpecification(int countryid, string name, int id)
            : base(i => i.CountryID == countryid && i.Name == name && i.Id != id)
        {
        }
    }
}
