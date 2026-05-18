using System;

namespace SwitchExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sitename = "mva";

            var result = sitename switch
            {
                "mva" => 2,
                "ali" => 3,
                _ => 4 //default value
            };

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
