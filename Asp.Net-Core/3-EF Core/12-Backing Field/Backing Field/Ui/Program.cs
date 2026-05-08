using DAL;
using Entities;
using System;
using System.Linq;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context= new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Blog blog = new Blog()
            {
            };
            blog.SetUrl("https://www.google.com");

            context.Blogs.Add(blog);
            context.SaveChanges();

            var result = context.Blogs.FirstOrDefault();
            Console.WriteLine(result.Url);

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
