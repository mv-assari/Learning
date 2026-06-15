using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Temp_with_Query
{
    public class OrderProcessor_Before
    {
        public decimal ProcessOrder(Order order)
        {
            // محاسبه قیمت پایه
            decimal itemsTotal = 0;
            foreach (var item in order.Items)
            {
                itemsTotal += item.Price * item.Quantity;
            }

            // محاسبه وزن کل
            decimal totalWeight = 0;
            foreach (var item in order.Items)
            {
                totalWeight += item.Weight * item.Quantity;
            }

            // محاسبه هزینه حمل
            decimal shippingCost = 0;
            if (totalWeight < 5)
                shippingCost = 10000;
            else if (totalWeight < 20)
                shippingCost = 25000;
            else
                shippingCost = 50000;

            // محاسبه تخفیف
            decimal discount = 0;
            if (itemsTotal > 500000)
                discount = itemsTotal * 0.15m;
            else if (itemsTotal > 200000)
                discount = itemsTotal * 0.05m;

            // محاسبه مالیات
            decimal tax = (itemsTotal - discount) * 0.09m;

            // قیمت نهایی
            decimal finalPrice = itemsTotal - discount + tax + shippingCost;

            return finalPrice;
        }
    }
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

    public class OrderItem
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
    }
}
