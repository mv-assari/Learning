using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
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


            //var result=products.Where(delegate (Product p)
            //{
            //    return p.Id == 1;
            //});

            var result = products.Where(p => p.Id == 1);// be in alamat => lambda migan

            Console.WriteLine("Hello World!");
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
