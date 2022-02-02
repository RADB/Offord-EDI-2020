using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class SiteFilterSpecification : BaseSpecification<Site>
    {
        public SiteFilterSpecification(string sitenumbder, int yearid)
            : base(i => i.SiteNumber.ToLower().Trim() == sitenumbder.ToLower().Trim() && i.YearId == yearid)
        {
        }

        public SiteFilterSpecification(string sitenumbder, int yearid, int id)
            : base(i => i.SiteNumber.ToLower().Trim() == sitenumbder.ToLower().Trim() && i.YearId == yearid && i.Id != id)
        {
        }
    }
}
