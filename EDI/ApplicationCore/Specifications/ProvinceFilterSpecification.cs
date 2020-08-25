using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class ProvinceFilterSpecification : BaseSpecification<Province>
    {
        public ProvinceFilterSpecification(int countryid)
            : base(i => i.CountryID == countryid
            )
        {
        }

        public ProvinceFilterSpecification(int countryid, string name)
            : base(i => i.CountryID == countryid && i.English == name)
        {
        }

        public ProvinceFilterSpecification(int countryid, string name, int id)
            : base(i => i.CountryID == countryid && i.English == name && i.Id != id)
        {
        }
    }
}
