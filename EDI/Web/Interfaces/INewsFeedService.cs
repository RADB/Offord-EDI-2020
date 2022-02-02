using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface INewsFeedService
    {
        Task DeleteNewsFeedAsync(int Id);

        Task UpdateNewsFeedAsync(NewsFeedItemViewModel newsFeed);

        Task<int> CreateNewsFeedAsync(NewsFeedItemViewModel newsFeed);

        Task<NewsFeedItemViewModel> GetNewsFeedItem(int newsFeedId);

        Task<int> GetDuplicateCount(string title, int yearid);
        Task<int> GetDuplicateCount(string title, int id, int yearid);
    }
}
