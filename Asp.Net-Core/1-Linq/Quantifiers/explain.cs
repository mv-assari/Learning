using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
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

            //نکته ای که برای این متد هست اینه که اگر یکی از اعضای لیست شرط رو برآورده نکنند متد تا آخر لیست به کار خودش ادامه میده و این برای سیستم سربار داره
            var allResult = products.All(p => p.Price > 5000); //کل لیست رو پیمایش میکنه و شرط رو بررسی میکنه اگر همه برقرار بود نتیجه مثبت برمیگردونه و درغیر این صورت منفی         
            Console.WriteLine(allResult);


            var anyResult = products.Any(p=>p.Price>5000); //این متد اولین موردی که در لیست شرط و برآورده بکنه جواب مثبت یا منفی رو برمیگردونه
            Console.WriteLine(anyResult);

            var containResult = products.Where(p=>p.Name.Contains("P"));

            foreach (var item in containResult)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
