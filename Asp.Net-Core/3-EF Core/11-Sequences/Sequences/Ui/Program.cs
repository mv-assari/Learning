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

            for (int i = 0; i < 100; i++)
            {
                Order order = new Order()
                {
                    InsertDate = DateTime.Now
                };
                context.Orders.Add(order);
            }

            context.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
