using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class SchoolFilterSpecification : BaseSpecification<Schools>
    {
        public SchoolFilterSpecification(string schoolnumbder)
            : base(i => i.SchoolNumber.ToLower().Trim() == schoolnumbder.ToLower().Trim())
        {
        }

        public SchoolFilterSpecification(string schoolnumbder, int id)
            : base(i => i.SchoolNumber.ToLower().Trim() == schoolnumbder.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
