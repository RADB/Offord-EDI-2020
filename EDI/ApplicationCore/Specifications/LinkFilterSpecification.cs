using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class LinkFilterSpecification : BaseSpecification<Link>
    {
        public LinkFilterSpecification(string url)
            : base(i => i.Url.ToLower().Trim() == url.ToLower().Trim())
        {
        }

        public LinkFilterSpecification(string url, int id)
            : base(i => i.Url.ToLower().Trim() == url.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
