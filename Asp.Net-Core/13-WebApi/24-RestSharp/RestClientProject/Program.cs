using RestSharp;
using System;

namespace RestClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // برای استفاده از ای پی آی های ساخته شده در سی شارپ میتوان از کتابخانه رست شارپ میتوان به صورت زیر استفاده کرد
            var client = new RestClient("https://localhost:44345/");
            var getSmsRequest=new RestRequest("api/Account/GetSmsCode",Method.GET);
            getSmsRequest.AddParameter("phoneNumber", "09101396666");
            var getSmsResult=client.Get(getSmsRequest);
        }
    }
}
