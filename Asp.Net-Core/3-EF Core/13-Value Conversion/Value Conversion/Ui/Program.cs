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


            Order order = new Order()
            {
                OrderStatus = OrderStatus.Sent,
                Done = true
            };
            context.Orders.Add(order);
            context.SaveChanges();

            User user = new User()
            {
                Email = "mva@gmail.comm"
            };
            context.Users.Add(user);
            context.SaveChanges();

            var resutl = context.Users.ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
