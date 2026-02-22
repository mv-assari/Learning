using System;
using System.Collections.Generic;
using System.Linq;

namespace Partitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IList<int> data=new List<int> { 5, 2, 4, 7, 8, 1 };

            var skipResult = data.Skip(2);

            var skipWhileResult = data.SkipWhile(r => r > 4);

            var takeResult=data.Take(2);

            var takeWhileResult=data.TakeWhile(x=>x> 4);

            Console.ReadKey();
        }
    }
}
