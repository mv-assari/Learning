using ApplicationSevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MailService
    {
        public void Send()
        {

        }

        public void OnUserRegistred(object source,UserDataEventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Send Email For User .... {args.Email} !");
        }
    }
}
