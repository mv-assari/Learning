//using System;
//using System.Collections.Generic;

//namespace Move_Method
//{
//    public class Before
//    {
//    }
//    public class Order
//    {
//        public Customer Customer { get; set; }
//        public List<OrderItem> Items { get; set; }

//        // این متد فقط با Customer کار داره
//        public bool IsCustomerVIP()
//        {
//            return Customer.TotalPurchases > 100000000 && Customer.YearsAsMember > 3;
//        }

//        // این متد فقط با Items کار داره - ولی توی Order هست (درسته بمونه)
//        public decimal CalculateTotal()
//        {
//            decimal total = 0;
//            foreach (var item in Items)
//                total += item.Price * item.Quantity;
//            return total;
//        }

//        // این متد هم فقط با Customer کار داره
//        public string GetCustomerContact()
//        {
//            return $"{Customer.Name} - {Customer.Email} - {Customer.Phone}";
//        }
//    }

//    public class Customer
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public decimal TotalPurchases { get; set; }
//        public int YearsAsMember { get; set; }
//    }
//}
