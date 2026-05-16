using ApplicationSevice;
using Infrastructure;
using System;

namespace Project_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MailService mailService = new MailService();
            DiscountService discountService = new DiscountService();
            UserRespository userRespository = new UserRespository();
            userRespository.UserRegistred += mailService.OnUserRegistred;
            userRespository.UserRegistred += discountService.OnUserRegistred;
            userRespository.RegisterUser("mva@gmail.com", "Pass");

            Console.ReadLine();
        }

    }
}
