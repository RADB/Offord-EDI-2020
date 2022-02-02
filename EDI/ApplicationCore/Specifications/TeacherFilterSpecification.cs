using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class TeacherFilterSpecification : BaseSpecification<Teacher>
    {
        public TeacherFilterSpecification(int schoolid, int yearid)
            : base(i => i.SchoolId == schoolid && i.YearId == yearid)
        {
        }

        public TeacherFilterSpecification(int schoolid, int yearid, string teachernumbder)
            : base(i => i.SchoolId == schoolid && i.YearId == yearid && i.TeacherNumber.ToLower().Trim() == teachernumbder.ToLower().Trim())
        {
        }

        public TeacherFilterSpecification(int schoolid, int yearid, string teachernumbder, int id)
            : base(i => i.SchoolId == schoolid && i.YearId == yearid && i.TeacherNumber.ToLower().Trim() == teachernumbder.ToLower().Trim() && i.Id != id)
        {
        }

        public TeacherFilterSpecification(string teachername, int yearid, string email)
            : base(i => i.TeacherName.ToLower().Trim() == teachername.ToLower().Trim() && i.YearId == yearid && i.Email.ToLower().Trim() == email.ToLower().Trim())
        {
        }

        public TeacherFilterSpecification(string teachername, int yearid, string email, int id)
            : base(i => i.TeacherName.ToLower().Trim() == teachername.ToLower().Trim() && i.YearId == yearid && i.Email.ToLower().Trim() == email.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
