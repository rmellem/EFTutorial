
using EFTutorial.Context;
using EFTutorial.Models;

namespace EFTutorial
{
    public class EFTutorial
    {
        public static void Main()
        {
            // Add Blog
            //using (var db = new BloggingContext())
            //{
            //    var blog = new Blog()
            //    {
            //        Name="YourBlog",
            //        Url="http://yourblog.com"
            //    };
            //    db.Blogs.Add(blog);
            //    db.SaveChanges();
            //}

            // List Blogs
            Console.WriteLine("Your blogs are ...");
            using (var db = new BloggingContext())
            {
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($"Blog #{blog.BlogId}: {blog.Name}");
                }
            }

            // Update Blog
            using (var db = new BloggingContext())
            {
                var blog = db.Blogs.Where(x => x.BlogId == 2).FirstOrDefault();
                blog.Name = "TheirBlog";
                blog.Url = "http://theirblog.com";
                db.Blogs.Update(blog);
                db.SaveChanges();
            }

            // List Blogs
            Console.WriteLine("Your blogs are ...");
            using (var db = new BloggingContext())
            {
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($"Blog #{blog.BlogId}: {blog.Name}");
                }
            }

            // Add Post
            //using (var db = new BloggingContext())
            //{
            //    var blog = db.Blogs.Where(x => x.BlogId == 2).FirstOrDefault();


            //    var post = new Post()
            //    {
            //        Title = "New Post",
            //        BlogId = 2
            //    };

            //}
        }
    }
}