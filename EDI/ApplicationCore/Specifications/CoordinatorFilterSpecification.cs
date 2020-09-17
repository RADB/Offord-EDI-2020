using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class CoordinatorFilterSpecification : BaseSpecification<Coordinator>
    {
        public CoordinatorFilterSpecification(string name, string email)
            : base(i => i.CoordinatorName.ToLower().Trim() == name.ToLower().Trim() && i.Email.ToLower().Trim() == email.ToLower().Trim())
        {
        }

        public CoordinatorFilterSpecification(string name, string email, int id)
            : base(i => i.CoordinatorName.ToLower().Trim() == name.ToLower().Trim() && i.Email.ToLower().Trim() == email.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
