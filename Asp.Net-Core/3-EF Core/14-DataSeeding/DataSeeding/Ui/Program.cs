using DAL;
using System;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context=new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Console.WriteLine("Hello World!");
        }
    }
}
