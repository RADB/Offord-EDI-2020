using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class CoordinatorFilterSpecification : BaseSpecification<Coordinator>
    {
        public CoordinatorFilterSpecification(string name, string email, int yearid)
            : base(i => i.CoordinatorName.ToLower().Trim() == name.ToLower().Trim() && i.Email.ToLower().Trim() == email.ToLower().Trim() && i.YearId == yearid)
        {
        }

        public CoordinatorFilterSpecification(string name, string email, int yearid, int id)
            : base(i => i.CoordinatorName.ToLower().Trim() == name.ToLower().Trim() && i.Email.ToLower().Trim() == email.ToLower().Trim() && i.YearId == yearid && i.Id != id)
        {
        }
    }
}
