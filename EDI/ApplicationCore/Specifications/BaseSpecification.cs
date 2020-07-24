using EDI.ApplicationCore.Interfaces;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace EDI.ApplicationCore.Specifications
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        protected BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public List<string> IncludeStrings { get; } = new List<string>();
        public Expression<Func<T, object>> OrderBy { get; set; }
        public Expression<Func<T, object>> OrderByDescending { get; set; }

        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool isPagingEnabled { get; private set; } = false;

        protected virtual void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
        protected virtual void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            isPagingEnabled = true;
        }
        protected virtual void ApplyPagingAsc(int skip, int take, Expression<Func<T, object>> orderByExpression)
        {
            Skip = skip;
            Take = take;
            isPagingEnabled = true;
            OrderBy = orderByExpression;
        }
        protected virtual void ApplyPagingDesc(int skip, int take, Expression<Func<T, object>> orderByDescendingExpression)
        {
            Skip = skip;
            Take = take;
            isPagingEnabled = true;

            OrderByDescending = orderByDescendingExpression;
        }
        protected virtual void ApplyOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        protected virtual void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescendingExpression)
        {
            OrderByDescending = orderByDescendingExpression;
        }
    }
}
