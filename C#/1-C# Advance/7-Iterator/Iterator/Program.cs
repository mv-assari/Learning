using System;
using System.Collections.Generic;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("a");
            names.Add("b");
            names.Add("c");
            names.Add("d");
            names.Add("e");
            names.Add("f");
            names.Add("g");


            var iterator=names.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            var name = GetNames().GetEnumerator();
            name.MoveNext();
            var a=name.Current;





            Console.ReadLine();
        }

        private static IEnumerable<string> GetNames()
        {
            yield return "mohammad";
            yield return "vahid";
            yield return "Fatemeh";
        }
    }
}
