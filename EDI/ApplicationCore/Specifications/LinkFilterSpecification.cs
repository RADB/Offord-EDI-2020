using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class LinkFilterSpecification : BaseSpecification<Link>
    {
        public LinkFilterSpecification(string url, int yearid)
            : base(i => i.Url.ToLower().Trim() == url.ToLower().Trim() && i.YearId == yearid)
        {
        }

        public LinkFilterSpecification(string url, int yearid, int id)
            : base(i => i.Url.ToLower().Trim() == url.ToLower().Trim() && i.YearId == yearid && i.Id != id)
        {
        }
    }
}
