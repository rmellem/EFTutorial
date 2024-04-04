using EFTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTutorial.Context
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public BloggingContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=bitsql.wctc.edu;Database=mmcarthey_20023_blogging;User Id=mmcarthey;Password=000075813;");
        }
    }
}
