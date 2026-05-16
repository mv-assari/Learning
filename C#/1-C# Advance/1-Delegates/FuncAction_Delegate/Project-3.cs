using System;

namespace FuncAction_Delegate
{
    internal class Program
    {
        //Project-3
        static void Main(string[] args)
        {
            Console.WriteLine("enter Number1");
            string num1 = Console.ReadLine();
            Console.WriteLine("enter Number2");
            string num2 = Console.ReadLine();

            int num11 = Convert.ToInt32(num1);
            int num22 = Convert.ToInt32(num2);


            //CalculatorDelegate calculator;
            //calculator = Calculator.Add;
            //Console.WriteLine($"Result:{calculator(num11,num22)}");

            //calculator = Calculator.Subtract;
            //Console.WriteLine($"Result:{calculator(num11,num22)}");

            //calculator = Calculator.Multiply;
            //Console.WriteLine($"Result:{calculator(num11,num22)}");

            //calculator = Calculator.Divide;
            //Console.WriteLine($"Result:{calculator(num11,num22)}");

            Func<int,int,double>[] operations =
            {
                Calculator.Add,
                Calculator.Subtract,
                Calculator.Multiply,
                Calculator.Divide
            };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Run Operation {i}");
                RunMethod(operations[i], num11, num22);
            }


            Console.ReadLine();
        }

        public static void RunMethod(Func<int,int,double> action, int a, int b)
        {
            Console.WriteLine($"Number1: {a} Number2: {b}    Result:{action.Invoke(a, b)}");
        }
    }
    public static class Calculator
    {
        public static double Add(int a, int b)
        {
            return a + b;
        }

        public static double Subtract(int a, int b)
        {
            return a - b;
        }

        public static double Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
