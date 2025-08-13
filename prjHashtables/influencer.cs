using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjHashtables 
{
    class Influencer
    {
        public string Username { get; set; }
        public int Follows { get; set; }
        public double EngagementRate { get; set; }
        public string LatestPost { get; set; }

        public Influencer(string username, int follows, double engagementRate, string latestPost)
        {
            Username = username;
            Follows = follows;
            EngagementRate = engagementRate;
            LatestPost = latestPost;
        }
        public override string ToString()
        {
            return $"Username: {Username}, Follows: {Follows}, Engagement Rate: {EngagementRate}, Latest Post: {LatestPost}";
        }
    }
}