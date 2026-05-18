using System;

namespace InitOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Id = 1
            };

            Console.WriteLine("Hello World!");
        }
    }

    public class Product
    {
        //توسط این نوع میتوان فقط یک مرتبه به پراپرتی مقداری اختصاص داد
        public int Id { get; init; }
    }
}
