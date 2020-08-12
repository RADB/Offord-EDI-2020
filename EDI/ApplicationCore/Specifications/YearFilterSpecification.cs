using System;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class YearFilterSpecification : BaseSpecification<Year>
    {
        public YearFilterSpecification(int year)
            : base(i => i.Ediyear == year)
        {
        }

        public YearFilterSpecification(int year, int id)
            : base(i => i.Ediyear == year && i.Id != id)
        {
        }
    }
}
