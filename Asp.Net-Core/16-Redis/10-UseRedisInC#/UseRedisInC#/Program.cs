using StackExchange.Redis;
using System;

namespace UseRedisInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ابتدا باید کتابخانه 
            //dotnet add package StackExchange.Redis
            //نصب کنیم سپس با استفاده از دستورات زیر از آن استفاده کنیم

            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase db=connection.GetDatabase();

            // db.StringSet("keytestinc#", "from c#");

            //string myvlaue = db.StringGet("keytestinc#");


            Console.WriteLine(DateTime.Now.TimeOfDay);
            for (int i = 0; i < 5000; i++)
            {
                db.StringSet($"user:{i}", "i==" + i);
            }

            Console.WriteLine(DateTime.Now.TimeOfDay);
            
            Console.ReadLine();
        }
    }
}
