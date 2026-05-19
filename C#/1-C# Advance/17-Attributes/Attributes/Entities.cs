using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class User
    {
        public User(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Product
    {
        public Product(int id, string name, string description, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        [ColorText(ConsoleColor.Green)]
        public int Id { get; set; }

        [ColorText]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }


}
