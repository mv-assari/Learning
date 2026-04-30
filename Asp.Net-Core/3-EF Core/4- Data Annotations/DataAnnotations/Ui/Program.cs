using System;
using DAL;

namespace Ui
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context = new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Console.WriteLine("Hello World!");
        }
    }
}
