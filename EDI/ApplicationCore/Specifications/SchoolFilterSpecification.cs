using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class SchoolFilterSpecification : BaseSpecification<School>
    {
        public SchoolFilterSpecification(int siteid, int yearid)
            : base(i => i.SiteId == siteid && i.YearId == yearid)
        {
        }

        public SchoolFilterSpecification(int siteid, int yearid, string schoolnumbder)
            : base(i =>i.SiteId == siteid && i.YearId == yearid && i.SchoolNumber.ToLower().Trim() == schoolnumbder.ToLower().Trim())
        {
        }

        public SchoolFilterSpecification(int siteid, int yearid, string schoolnumbder, int id)
            : base(i => i.SiteId == siteid && i.YearId == yearid && i.SchoolNumber.ToLower().Trim() == schoolnumbder.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
