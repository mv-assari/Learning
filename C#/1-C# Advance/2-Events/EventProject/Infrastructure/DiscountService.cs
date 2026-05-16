using ApplicationSevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DiscountService
    {
        public void OnUserRegistred(object source,UserDataEventArgs args)
        {
            Thread.Sleep(4000);
            Console.WriteLine($"Discount Set for User .... {args.Email} !");
        }
    }
}
