using System;
using System.Collections.Generic;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User type
            User user = new User()
            {
                Id = 1,
                Name = "Test",
            };

            //Anonymous type
            var product = new
            {
                Id = 1,
                Name = "shelang"
            };

            var users = new[]
            {
                new{Id=1,Name="Test1"},
                new{Id=2,Name="Test2"},
                new{Id=3,Name="Test3"},
                new{Id=4,Name="Test4"},
            };

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(product.Id);

            Console.ReadLine();
        }

        //for return anonymous type we used dynamic keyword
        dynamic GetUsers()
        {
            var users = new[]
           {
                new{Id=1,Name="Test1"},
                new{Id=2,Name="Test2"},
                new{Id=3,Name="Test3"},
                new{Id=4,Name="Test4"},
            };
            return users;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
