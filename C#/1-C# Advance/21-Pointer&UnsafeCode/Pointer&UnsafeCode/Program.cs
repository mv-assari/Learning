using System;

namespace Pointer_UnsafeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int number = 154;
                int* p = &number;

                Console.WriteLine($"number:{number}");
                Console.WriteLine($"address number:{(int)p}");
                Console.WriteLine($"data p:{p->ToString()}");
            }

            Console.ReadLine();
        }
    }
}
