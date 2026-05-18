using System;
using System.Collections;
using System.Collections.Generic;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========declaration and type pattern==========");

            object text = "Hi vahid";
            if (text is string message)
            {
                Console.WriteLine(message);
            }

            var number =new int[] {1,2,3,4,5,6 };
            Console.WriteLine(GetSourceLab(number));

            static string GetSourceLab<T>(IEnumerable<T> source)
            {
                return source switch
                {
                    Array array=>"is array",
                    ICollection<T> collection=> "is List",
                    _ => "unkown",
                };
            }

            Console.WriteLine("=========Constant pattern==========");

            int n = 5;
            var result = n switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                _ => "Unknown"
            };

            Console.WriteLine(result);

            Console.WriteLine("=========Relational pattern==========");

            // < <= > >=

            static string MosbatYaManfi(int number)
            {
                return number switch
                {
                    < 0 => "manfi ast",
                    > 0 => "mosbat ast",
                    _ => "Unknown"
                };
            }

            Console.WriteLine(MosbatYaManfi(100));
            Console.WriteLine(MosbatYaManfi(-50));

            Console.WriteLine("=========Logical pattern==========");
            // and or not 

            if (args is not null)
            {
                //
            }

            static string GetStateScore(byte score)
            {
                return score switch
                {
                    < 5 and > 0 => "kheili bad",
                    < 10 and >= 5 => "bad",
                    < 15 and >= 10 => "mamooli",
                    <= 20 and >= 15 => "alii"
                };
            }

            Console.WriteLine(GetStateScore(18)) ;

            Console.WriteLine("=========Property pattern==========");

            static bool IsAcceptBrithdate(DateTime date)
            {
                return date is { Year: 2010 or 2011 or 2012 };
                
            }
            Console.WriteLine(IsAcceptBrithdate(DateTime.Now.AddYears(-13)));

            User user = new User() { Id = 1, Name = "vahid", Age = 21 };

            //static bool IsAcceptUser(User user)
            //{
            //    return user is { Name: "vahid", Age: 20 or 21 };
            //}
            //Console.WriteLine(IsAcceptUser(user));

            static bool IsAcceptUser(User user)
            {
                return user switch
                {
                    { Name: "ali" or "hamid", Age: 24 or 25 } => true,
                    { Age: 23, Id: 10 } =>true,
                    _ => false
                };
            }
            Console.WriteLine(IsAcceptUser(user));

            Console.WriteLine("=========Positional pattern==========");

            static string GetResolation(int x , int y)
            {
                return (x, y) switch
                {
                    (640,480)=> "SD",
                    (1280,720)=> "HD",
                    (1920,1080)=> "FullHD",
                };
            }
            Console.WriteLine(GetResolation(1280,720));

            static string GetPosition(Location location)
            {
                return location switch
                {
                    (10, 10) => "bala",
                    (20, 20) =>"paien"
                };
            }
            Console.WriteLine(GetPosition(new Location { Lat=10,Lng=10}));


            Console.WriteLine("=========Var pattern==========");

            static bool IsVahidDomain(string domain)
            {
                return domain.ToUpper() is var upperDomain &&
                    (
                        upperDomain == "MVA.COM" ||
                        upperDomain =="HTTP://MVA.COM" ||
                        upperDomain =="HTTPS://MVA.COM"
                    );
            }

            Console.WriteLine(IsVahidDomain("MVA.COM"));


            Console.ReadLine(); 
        }
    }

    public class Location
    {
        public int Lat { get; set; }
        public int Lng { get; set; }

        public void Deconstruct(out int x,out int y)
        {
            x = Lat;
            y = Lng;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
