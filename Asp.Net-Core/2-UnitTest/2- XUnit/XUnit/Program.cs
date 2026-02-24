using System;

namespace XUnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper=new MathHelper();
            while (true)
            {
                Console.WriteLine("X re vared konid:");
                int x=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Y ra vared konid:");
                int y=Convert.ToInt32(Console.ReadLine());

                var result= mathHelper.Jam(x,y);

                Console.WriteLine($"X:{x} + Y:{y} = {result}");
            }
            Console.ReadKey();
        }
    }
}
