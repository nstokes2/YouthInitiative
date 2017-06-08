using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace YouthInitiative.Models
{
    public class VideoUrls
    {
        public int ID { get; set; }
        public string url { get; set; }
        public string userName { get; set; }


    }
    public class VideoUrlsDBContext : DbContext
    {
        public DbSet<VideoUrls> VideoUrls { get; set; }
    }
}