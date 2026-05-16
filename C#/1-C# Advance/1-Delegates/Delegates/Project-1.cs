using System;

namespace Delegates
{
    internal class Program
    {
        //Project-1
        delegate string MyDelegate();
        delegate double CalcNumber(int a,int b);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyMethod);
            var value = myDelegate.Invoke();
            Console.WriteLine($"Result:{value}");

            myDelegate=MyClass.GetString;
            Console.WriteLine($"Result:{myDelegate.Invoke()}");


            CalcNumber myCalc;
            myCalc = Div;
            var result2 = myCalc(8, 4);
            Console.WriteLine($"Result:{result2}");


            Console.ReadLine();
        }

        static string MyMethod()
        {
            return "My string ...";
        }

        static double Div(int a, int b)
        {
            return a / b;
        }
    }
    public static class MyClass
    {
        public static string GetString()
        {
            return "MyClass.string ...";
        }
    }
}
