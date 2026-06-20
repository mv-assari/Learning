using System;
using System.Collections.Generic;

namespace Move_Method
{
    public class After
    {
        public void MethodTest()
        {
            var customer = new Customer
            {
                Name = "علی",
                TotalPurchases = 150000000,
                YearsAsMember = 5
            };

            // حالا Customer خودش میتونه بگه VIP هست یا نه:
            if (customer.IsVIP())
                Console.WriteLine($"{customer.GetContactInfo()} - مشتری ویژه");

            // یا از طریق Order:
            var order = new Order { Customer = customer };
            if (order.Customer.IsVIP())
                Console.WriteLine("تخفیف ویژه");
        }
    }
    public class Order
    {
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }

        // این متد فقط با Items کار داره - ولی توی Order هست (درسته بمونه)
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
                total += item.Price * item.Quantity;
            return total;
        }

        
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal TotalPurchases { get; set; }
        public int YearsAsMember { get; set; }

        // این متد فقط با Customer کار داره
        public bool IsVIP()
        {
            return TotalPurchases > 100000000 && YearsAsMember > 3;
        }

        // این متد هم فقط با Customer کار داره
        public string GetContactInfo()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
