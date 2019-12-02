using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebsite.Models;

namespace MyWebsite.Data
{
    public class MyWebsiteContext : DbContext
    {
        public MyWebsiteContext (DbContextOptions<MyWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebsite.Models.Movie> Movie { get; set; }
        public DbSet<MyWebsite.Models.Blog> Blog { get; set; }
        public DbSet<MyWebsite.Models.Music> Music { get; set; }
    }
}
