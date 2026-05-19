using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public static class ExtentionMethod
    {
        public static void Print<T>(this T obj)
        {
            Type t=obj.GetType();
            Console.WriteLine($"Print {t.Name} class");
            var prop = t.GetProperties();
            foreach( var property in prop )
            {
                var colorText = property.GetCustomAttributes(false).FirstOrDefault() as ColorTextAttribute;
                if(colorText is not null)
                    Console.ForegroundColor = colorText.Color;
                Console.WriteLine($"{property.Name} : {property.GetValue(obj)}");
                Console.ForegroundColor= ConsoleColor.White;
            }
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
