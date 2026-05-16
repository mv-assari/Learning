using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="M1"},
                new Product{Id=2,Name="M2"},

            };

            var result = products.Where(
            
                delegate (Product p)
                    {
                        return p.Id == 1;
                    }
             );

            Console.WriteLine($"{result.ToList().FirstOrDefault().Name}");
            Console.ReadLine();
        }

        public static bool GetProduct(Product product)
        {
            if (product.Id==1)
                return true;
            return false;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
