using DAL;
using Entities;
using System;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataBaseContext context = new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            User user = new User()
            {
               // Id= 1,
                FirstName = "vahid",
                LastName = "Assari",
            };

            context.Users.Add(user);
            context.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
