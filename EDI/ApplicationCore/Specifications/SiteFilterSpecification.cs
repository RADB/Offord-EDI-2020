using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class SiteFilterSpecification : BaseSpecification<Site>
    {
        public SiteFilterSpecification(string sitenumbder)
            : base(i => i.SiteNumber.ToLower().Trim() == sitenumbder.ToLower().Trim())
        {
        }

        public SiteFilterSpecification(string sitenumbder, int id)
            : base(i => i.SiteNumber.ToLower().Trim() == sitenumbder.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
