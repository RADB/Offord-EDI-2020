using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class NewsFeedFilterSpecification : BaseSpecification<NewsFeed>
    {
        public NewsFeedFilterSpecification(string title, int yearid)
            : base(i => i.Title.ToLower().Trim() == title.ToLower().Trim() && i.YearId == yearid)
        {
        }

        public NewsFeedFilterSpecification(string title, int yearid, int id)
            : base(i => i.Title.ToLower().Trim() == title.ToLower().Trim() && i.YearId == yearid && i.Id != id)
        {
        }
    }
}
