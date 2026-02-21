using System;
using System.Collections.Generic;
using System.Linq;

namespace Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> data = new List<string>() { "ASP.Net Core","C#","Php","Java","NodeJs","GoLang"};

            var sep = data.Aggregate((s1, s2) => s1 + "," + s2);

            Console.WriteLine(sep);
            Console.WriteLine("___________________________________________");

            List<Product> products = new List<Product>
            {
                new Product{Name="ASP.Net Core",Price=10000},
                new Product{Name="C#",Price=20000},
                new Product{Name="Php",Price=30000},
                new Product{Name="Java",Price=40000},
                new Product{Name="NodeJs",Price=50000},
                new Product{Name="GoLang",Price=60000},
            };

            var sep2 = products.Aggregate<Product, string,string>("Product Name:", (str, p) => str += p.Name + ",",str=>str.Substring(0,str.Length-1));
            Console.WriteLine(sep2);


            var avg = products.Average(p => p.Price).ToString(); //if empty list, it's error
            Console.WriteLine(avg);

            var count=products.Count();
            Console.WriteLine(count);

            var longCount=products.LongCount();
            Console.WriteLine(longCount);

            var max = products.Max(p => p.Price); //if empty list, it's error
            Console.WriteLine(max);

            var min = products.Min(p => p.Price); //if empty list, it's error
            Console.WriteLine(min);

            var sum=products.Sum(p=>p.Price);
            Console.WriteLine(sum);


            Console.ReadKey();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
