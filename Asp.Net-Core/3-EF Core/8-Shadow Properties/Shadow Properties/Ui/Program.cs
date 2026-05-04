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
            DataBaseContext context = new DataBaseContext();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //Product product = new Product
            //{
            //    Category = new Category { CategoryName = "Laptop" },
            //    Name = "Hp",
            //    Price = 1500000
            //};

            //context.Products.Add(product);

            var product = context.Products.FirstOrDefault();
            context.Entry(product).Property("InsertDate").CurrentValue = DateTime.Now;

            var fk=context.Entry(product).Property("CategoryId").CurrentValue;

            context.SaveChanges();

            var fk2=context.Entry(product).Property("CategoryId").CurrentValue;

            Console.WriteLine("Hello World!");
        }
    }
}
