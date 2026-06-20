using System;

namespace Inline_Class
{
    public class Before
    {
    }

    // کلاس تقریباً خالی
    public class Phone
    {
        public string Number { get; set; }
        public string Type { get; set; } // Mobile, Home, Work
    }

    public class Contact
    {
        public string Name { get; set; }
        public Phone Phone { get; set; }

        public void DisplayContact()
        {
            Console.WriteLine($"{Name}: {Phone.Number} ({Phone.Type})");
        }
    }
}
