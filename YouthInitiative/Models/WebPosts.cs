using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace YouthInitiative.Models
{
    public class WebPosts
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string message { get; set; }
    }


    public class WebPostContext : DbContext
    {



        //    DbSet<WebPost> WebPost { get; set; }

        public DbSet<WebPosts> WebPosts { get; set; }
    }
}