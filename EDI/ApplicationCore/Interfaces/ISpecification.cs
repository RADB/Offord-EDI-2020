using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EDI.ApplicationCore.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        Expression<Func<T, object>> OrderBy { get; set; }
        Expression<Func<T, object>> OrderByDescending { get; set; }

        int Take { get; }
        int Skip { get; }
        bool isPagingEnabled { get;}
    }
}
