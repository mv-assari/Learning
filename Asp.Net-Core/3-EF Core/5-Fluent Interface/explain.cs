using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class explain
    {
        static void Main(string[] args)
        {

            List<Prodcut> prodcuts = new List<Prodcut>()
            {
                new Prodcut{Id=1,Name="Apple",Price=10000 },
                new Prodcut{Id=2,Name="Iphone",Price=20000 },
                new Prodcut{Id=3,Name="Lg",Price=30000 },
                new Prodcut{Id=4,Name="Samsuong",Price=40000 }
            };

            //is not fluent
            var contain=prodcuts.Where(p=>p.Name.Contains('p'));
            var order = prodcuts.OrderByDescending(p => p.Id);
            var select = order.Select(p => new { p.Name});

            //is fluent
            var result=prodcuts.Where(p=>p.Name.Contains('p'))
                               .OrderByDescending(p => p.Id)
                               .Select(p => p.Name);

            Console.WriteLine("Hello World!");
        }
    }

    public class ProductService
    {
        private Prodcut _product =new Prodcut();

        public ProductService Id(long id)
        {
            _product.Id = id;
            return this;
        }

        public ProductService Name(string name)
        {
            _product.Name = name;
            return this;
        }

        public ProductService Price(int price)
        {
            _product.Price = price;
            return this;
        }

        public void Print()
        {
            Console.WriteLine($"Id:{_product.Id} Name:{_product.Name} Price:{_product.Price}");
        }
    }

    public class Prodcut
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
