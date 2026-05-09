using DAL;
using Microsoft.EntityFrameworkCore;
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


            //میتونیم روی اینکلود ها فیلتر بزاریم
            //context.Posts.Include(p => p.Tags.Where(t => t.Text.Contains("M")));


            //پاک کردن فضای اسنپ شات 
            //context.ChangeTracker.Clear();

            Console.WriteLine("Hello World!");
        }
    }
}
