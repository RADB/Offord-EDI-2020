using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class TeacherFilterSpecification : BaseSpecification<Teacher>
    {
        public TeacherFilterSpecification(string teachernumber)
            : base(i => i.TeacherNumber.ToLower().Trim() == teachernumber.ToLower().Trim())
        {
        }

        public TeacherFilterSpecification(string teachernumber, int id)
            : base(i => i.TeacherNumber.ToLower().Trim() == teachernumber.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
