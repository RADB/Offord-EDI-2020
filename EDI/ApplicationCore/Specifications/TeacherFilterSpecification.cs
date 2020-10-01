using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class TeacherFilterSpecification : BaseSpecification<Teacher>
    {
        public TeacherFilterSpecification(string teachername, string email)
            : base(i => i.TeacherName.ToLower().Trim() == teachername.ToLower().Trim() && i.Email.ToLower().Trim() == email.ToLower().Trim())
        {
        }

        public TeacherFilterSpecification(string teachername, string email, int id)
            : base(i => i.TeacherName.ToLower().Trim() == teachername.ToLower().Trim() && i.Email.ToLower().Trim() == email.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
