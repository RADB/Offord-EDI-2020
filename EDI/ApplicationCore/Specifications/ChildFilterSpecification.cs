using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class ChildFilterSpecification : BaseSpecification<Child>
    {
        public ChildFilterSpecification(string ediid)
            : base(i => i.Ediid.ToLower().Trim() == ediid.ToLower().Trim())
        {
        }

        public ChildFilterSpecification(string ediid, int id)
            : base(i => i.Ediid.ToLower().Trim() == ediid.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
