using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class CustomerFilterSpecification : BaseSpecification<Customers>
    {
        public CustomerFilterSpecification(string name)
            : base(i => i.Name.ToLower().Trim() == name.ToLower().Trim())
        {
        }

        public CustomerFilterSpecification(string name, int id)
            : base(i => i.Name.ToLower().Trim() == name.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
