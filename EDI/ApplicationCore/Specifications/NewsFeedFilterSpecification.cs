using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class NewsFeedFilterSpecification : BaseSpecification<NewsFeed>
    {
        public NewsFeedFilterSpecification(string title)
            : base(i => i.Title.ToLower().Trim() == title.ToLower().Trim())
        {
        }

        public NewsFeedFilterSpecification(string title, int id)
            : base(i => i.Title.ToLower().Trim() == title.ToLower().Trim() && i.Id != id)
        {
        }
    }
}
