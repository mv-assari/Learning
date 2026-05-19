using System;
using System.Runtime.CompilerServices;

namespace CallerInfoAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utitlity.MyMethod();
            Console.ReadLine();
        }
    }

    public static class Utitlity
    {
        public static void MyMethod(
            [CallerMemberName] string membername = null,
            [CallerFilePath] string filepath = null,
            [CallerLineNumber] int linenumber=0)
        {
            Console.WriteLine("MyMethod Run .... ");
            Console.WriteLine($"Method:{membername}");
            Console.WriteLine($"FilePath:{filepath}");
            Console.WriteLine($"LineNumber:{linenumber}");
        }
    }
}
