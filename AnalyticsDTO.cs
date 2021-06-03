using System;
using System.Collections.Generic;
using System.Text;

namespace Glitter.Shared.DTO
{
    public class AnalyticsDTO
    {
        public string TrendingHashTag { get; set; }
        public int TotalTweetsToday { get; set; }

        public string MostTweetPerson { get; set; }
        public string MostLikedTweet { get; set; }
    }
}
