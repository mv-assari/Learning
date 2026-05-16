using System;

namespace MultiCast_Delegate
{
    internal class Program
    {
        //Project-5
        static void Main(string[] args)
        {
            Action<int> action;
            action = M1;
            //action -= M1;
            action += M2;
            //action.Invoke(2);

            Delegate[] delegates=action.GetInvocationList();

            foreach (var item in delegates)
            {
                try
                {
                    item.DynamicInvoke(100);
                }
                catch (Exception)
                {

                    ;
                }
            }


            Console.ReadLine();
        }

        public static void M1(int number)
        {
            throw new Exception("Test");
            Console.WriteLine(number);
        }
        
        public static void M2(int number)
        {
            int resutl = number * 2;
            Console.WriteLine(resutl);
        }

    }
}
