using System;
//برای فعال کردن این مورد فقط روی این فایل از این طریق استفاده میکنیم یا برای غبرفعال کردن اون روی این فایل
//#nullable enable
namespace NullableReferenceType
{

//موارد زیر در قسمت تنظمیات پروژه تعریف میشه برای تبدیل وارنینگ ها به خطا یا تولید وارنینگ
//<Project Sdk = "Microsoft.NET.Sdk" >
//  < PropertyGroup >
//    < OutputType > Exe </ OutputType >
//    < TargetFramework > net5.0</TargetFramework>

//	  <Nullable>enable</Nullable> //این مورد 
//	  <!--<TreatWarningsAsErrors>true</TreatWarningsAsErrors>--> //این مورد
//	  <WarningsAsErrors>CS8600;CS8618;CS8602</WarningsAsErrors> //این مورد

//  </PropertyGroup>
//</Project>
    internal class Program
    {
        static void Main(string[] args)
        {

            string? name = null;
            Console.WriteLine(name);
            Console.WriteLine("Hello World!");
        }

        private int GetLengthEmail(User user)
        {
            var email=user.Email;
            return email?.Length??0;
        }
    }

    public class User
    {
        public User(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public User(string firstName,string lastName)
        {
            this.FirstName=firstName;
            this.LastName=lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
    }

    public class Order
    {
        public string OrderId { get; set; } = null!;
        public string Address { get; set; } = string.Empty;
    }

    public class OrderItem
    {
        public int Count { get; set; }
        public Order Order { get; set; }

        public OrderItem(Order order)
        {
            this.Order = order;
        }
    }
}
