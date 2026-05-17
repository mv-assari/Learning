using System;

namespace NullableValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Nullable<int> num = null;
            int a=num.GetValueOrDefault();

            Nullable<bool> boolvalue;
            boolvalue = null;
            boolvalue = boolvalue.GetValueOrDefault();

            bool? boolvalue2 = true;//با این علامت (؟) هم میتوان کار دستورات بالا را انجام داد 

            Console.WriteLine(boolvalue2.HasValue);
            boolvalue2=boolvalue2.GetValueOrDefault();

            Console.ReadLine();
        }
    }
}
