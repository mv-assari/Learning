using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "۹۹";

            title.FaToEnNumber();
            Order order = new Order
            {
                TotalPrice = 100
            };

            order.TotalPrice.ShowPrice();
            order.ShowPrice();

            object name = "ali";
            name.ShowInConsole();

            string name2 = "ali";
            name2.ShowInConsole();

            Console.ReadLine();
        }
    }

    public class Order
    {
        public int TotalPrice { get; set; }

        //به متدی که همنام با متد خارجی هست instance متد میگند
        //این متد در اجرا بر متد خارجی اولویت دارد
        public void ShowPrice()
        {
            Console.WriteLine(TotalPrice.ToString().Concat("extention method"));
        }
    }


    public static class Extentions
    {
        public static string FaToEnNumber(this string text)//extention method for string
        {
            Dictionary<char, char> LettersDictionary = new Dictionary<char, char>()
            {
                ['۰'] = '0',
                ['۱'] = '1',
                ['۲'] = '2',
                ['۳'] = '3',
                ['۴'] = '4',
                ['۵'] = '5',
                ['۶'] = '6',
                ['۷'] = '7',
                ['۸'] = '8',
                ['۹'] = '9'
            };

            return LettersDictionary.Aggregate(text, (current, item) =>
                                               current.Replace(item.Key, item.Value));
        }

        public static void ShowPrice(this int price)//extention method for int
        {
            Console.WriteLine(price.ToString());
        }

        public static void ShowPrice(this Order order)// extention method for Order class
        {
            Console.WriteLine(order.TotalPrice.ToString("n0").Concat("extention method"));
        }

        public static void ShowInConsole(this object text)//extention method for object
        {
            Console.WriteLine($"Object test:{text}");
        }

        public static void ShowInConsole(this string text)//extention method for string but method name is same to object
        {
            Console.WriteLine($"String text:{text}");
        }
    }
}
