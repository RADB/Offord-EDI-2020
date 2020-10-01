using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class SchoolFilterSpecification : BaseSpecification<School>
    {
        public SchoolFilterSpecification(int siteid)
            : base(i => i.SiteId == siteid)
        {
        }

        public SchoolFilterSpecification(int siteid, string schoolnumbder)
            : base(i =>i.SiteId == siteid && i.SchoolNumber.ToLower().Trim() == schoolnumbder.ToLower().Trim())
        {
        }

        public SchoolFilterSpecification(int siteid, string schoolnumbder, int id)
            : base(i => i.SiteId == siteid && i.SchoolNumber.ToLower().Trim() == schoolnumbder.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
