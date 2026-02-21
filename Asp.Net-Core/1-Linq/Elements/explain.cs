using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{Name="ASP.Net Core",Price=10000},
                new Product{Name="C#",Price=20000},
                new Product{Name="Php",Price=30000},
                new Product{Name="Java",Price=40000},
                new Product{Name="NodeJs",Price=50000},
                new Product{Name="GoLang",Price=60000},
            };

            var elementAtResult = products.ElementAt(0);//if list empty or notfound index -->error outofrange
            var elementAtResult2 = products.ElementAtOrDefault(10);//if list empty or notfound index --> not error and result is null

            var firstResult = products.First(p => p.Price > 30000); // if list empty or onject not found --> error not match
            var firstResult2 = products.FirstOrDefault(p => p.Price > 300000); // if list empty or onject not found --> not error and result is null

            var lastResult = products.Last(/* we can use condition */);// if list empty or object not found --> error not element
            var lastResult2 = products.LastOrDefault(/* we can use condition */);// if list empty or onject not found --> not error and result is null

            var singleResult = products.Single(/* we can use condition */);// if list empty or onject not found or more than one object --> error not match
            var singleResult2 = products.SingleOrDefault(/* we can use condition */);// if list more than one object --> error more than one object



            Console.ReadKey();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
