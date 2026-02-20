using System;
using System.Collections.Generic;
using System.Linq;

namespace Projection
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            List<Category1> categories = new List<Category1>
            {
                new Category1{Id=1,Name="Mobile"},
                new Category1{Id=2,Name="Laptop"}
            };

            List<Product1> products = new List<Product1>
            {
                new Product1{Id=1,Name="Samsoung",CategoryId=1 },
                new Product1{Id=2,Name="Apple",CategoryId=1 },
                new Product1{Id=3,Name="Lenovo",CategoryId=2 },
                new Product1{Id=4,Name="Hp",CategoryId=2 },
            };

            var result = products.Join(categories, p => p.CategoryId, c => c.Id, (cat, pro) => 
            new // select property to show in result  --> anonymous select
            {
                CategoryName=cat.Name,
                ProductName=pro.Name,
            });

            var result2 = products.Join(categories, p => p.CategoryId, c => c.Id, (pro,cat) =>
            new NewListDto1 //mapping to NewListDto  --> named select 
            {
                Id=pro.Id,
                Name=pro.Name,
                Category=cat.Name
            });

            foreach (var item in result2)
            {
                Console.WriteLine($"Id={item.Id} Name={item.Name} Category={item.Category}");
            }


            Console.ReadKey();
        }
    }

    public class NewListDto1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public class Category1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product1
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

    }
}
