using System;

namespace Inline_Class
{
    public class After
    {
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Type { get; set; } // Mobile, Home, Work

        public void DisplayContact()
        {
            Console.WriteLine($"{Name}: {Number} ({Type})");
        }
    }
}
