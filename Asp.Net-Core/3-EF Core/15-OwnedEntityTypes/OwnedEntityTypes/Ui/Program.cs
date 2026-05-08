using DAL;
using Entities;
using System;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext contxt=new DataBaseContext();

            contxt.Database.EnsureDeleted();
            contxt.Database.EnsureCreated();

            User user = new User()
            {
                Email = "mva@gmail.com",
                Home = new Address { City = "qom", Street = "pardisan", Alley = "motalefe", Plaque = "aisan2" },
                WorkPlace = new Address { City = "qom", Street = "pardisan", Alley = "molavi", Plaque = "park elmofanavari" }
            };

            contxt.Users.Add(user);
            contxt.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
