using System;
using System.Collections.Generic;

namespace QueryInDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ropository ropository = new Ropository();

            //var a= ropository.Add(new CustomerDto { FirstName="Hadi2",LastName="Assari2"});
            //Console.WriteLine(a);

            //OnToMany(ropository);

            //OneToOne(ropository);

            var orders=ropository.RunSp();

            Console.ReadLine();


        }

        private static void OneToOne(Ropository ropository)
        {
            var orders = ropository.GetInvoice();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order:{order.Id}  Date:{order.Date} Price:{order.Invoice.Price}");
            }
        }

        static void OnToMany(Ropository ropository)
        {
            var orders = ropository.GetOrders();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order:{order.Id}  Date:{order.Date}");

                foreach (var item in order.OrderDetails)
                {
                    Console.WriteLine($"Id:{item.Id} ProductName:{item.ProductName}");
                }
            }
        }
    }
}
