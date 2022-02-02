using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class ChildFilterSpecification : BaseSpecification<Child>
    {
        public ChildFilterSpecification(string ediid, int yearid)
            : base(i => i.Ediid.ToLower().Trim() == ediid.ToLower().Trim() && i.YearId == yearid)
        {
        }

        public ChildFilterSpecification(string ediid, int yearid, int id)
            : base(i => i.Ediid.ToLower().Trim() == ediid.ToLower().Trim() && i.YearId == yearid && i.Id != id)
        {
        }
    }
}
