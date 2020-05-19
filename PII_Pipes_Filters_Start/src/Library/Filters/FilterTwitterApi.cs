using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CompAndDel;
using System.Diagnostics;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitterApi : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            IPicture twitterImg = image.Clone();

            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";

            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("FilteredImage ",@"NewImage.jpg"));
            return twitterImg;
        }
    }
}