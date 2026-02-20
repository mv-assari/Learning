using System;
using System.Collections.Generic;
using System.Linq;

namespace Projection
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            List<Category2> categories = new List<Category2>
            {
                new Category2{ Id=1,Name="Mobile",Products=new List<Product2>()
                {
                    new Product2{Id=1,Name="Samsoung",CategoryId=1, InsertDate=DateTime.Now.AddYears(1) },
                    new Product2{Id=2,Name="Apple",CategoryId=1 , InsertDate=DateTime.Now.AddYears(-2)},
                } },
                new Category2{Id=2,Name="Laptop", Products=new List<Product2>
                {
                    new Product2{Id=3,Name="Lenovo",CategoryId=2 , InsertDate=DateTime.Now.AddYears(2)},
                    new Product2{Id=4,Name="Hp",CategoryId=2 , InsertDate=DateTime.Now.AddYears(-3)},
                } }
            };

            var result = categories.SelectMany(c => c.Products.Where(p => p.InsertDate > DateTime.Now).Select(r => new
            {
                Year = r.InsertDate.Year,
                ProductName = r.Name,
                Category = c.Name
            }));

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Year} {item.ProductName} {item.Category}");
            }


            var result2 = categories.Where(p => p.Products.Any(s => s.InsertDate > DateTime.Now));

            Console.ReadKey();
        }
    }

    public class NewListDto2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public class Category2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product2> Products { get; set; }
    }

    public class Product2
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
