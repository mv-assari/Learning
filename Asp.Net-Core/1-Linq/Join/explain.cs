using System;
using System.Collections.Generic;
using System.Linq;

namespace Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ Id=1,Name="Mobile"},
                new Category{Id=2,Name="Laptop"}
            };

            List<Product> products = new List<Product>
            {
                new Product{Id=1,Name="Samsoung",CategoryId=1 },
                new Product{Id=2,Name="Apple",CategoryId=1 },
                new Product{Id=3,Name="Lenovo",CategoryId=2 },
                new Product{Id=4,Name="Hp",CategoryId=2 },
            };

            var result = products.Join(categories, p => p.CategoryId,c=>c.Id, (p,c) => new //--> Join <--
            {
               ProductId= p.Id,
               ProductName= p.Name,
               CategoryName=c.Name
            });

            foreach (var item in result)
            {
                Console.WriteLine($"P.Id={item.ProductId}  P.Name={item.ProductName}  C.Name={item.CategoryName}");
            }

            Console.WriteLine("--------------------------------------------------------------------------");


            var result2 = categories.GroupJoin(products, c => c.Id, p => p.CategoryId, (c, p) => new // --> GroupJoin <--
            {
                product=p,
                category=c
            });

            foreach (var items in result2)
            {
                Console.WriteLine($"CategoryName={items.category.Name}");
                foreach (var item in items.product)
                {
                    Console.WriteLine($"ProductName={item.Name}");
                }
            }

            Console.ReadKey();
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
