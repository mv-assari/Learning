using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Temp_with_Query
{
    public class OrderProcessor_After
    {
        private decimal CalculateItemsTotal(Order order)
        {
            decimal itemsTotal = 0;
            foreach (var item in order.Items)
            {
                itemsTotal += item.Price * item.Quantity;
            }
            return itemsTotal;
        }
        private decimal CalculateTotalWeight(Order order)
        {
            decimal totalWeight = 0;
            foreach (var item in order.Items)
            {
                totalWeight += item.Weight * item.Quantity;
            }
            return totalWeight;
        }
        private decimal CalculateShippingCost(Order order)
        {
            var totalWeight=CalculateTotalWeight(order);

            if (totalWeight < 5)
                return 10000;
            if (totalWeight < 20)
                return 25000;
            
            return 50000;

        }
        private decimal CalculateDiscount(Order order)
        {
            var itemsTotal=CalculateItemsTotal(order);
            
            if (itemsTotal > 500000)
                return itemsTotal * 0.15m;
            if (itemsTotal > 200000)
                return itemsTotal * 0.05m;
            return 0;
        }
        private decimal CalculateTax(Order order)
        {
            return (CalculateItemsTotal(order) - CalculateDiscount(order)) * 0.09m;
        }
        public decimal ProcessOrder(Order order)
        {
            // محاسبه قیمت پایه
            var itemsTotal = CalculateItemsTotal(order);

            // محاسبه وزن کل
            var totalWeights = CalculateTotalWeight(order);

            // محاسبه هزینه حمل
            var shippingCost = CalculateShippingCost(order);

            // محاسبه تخفیف
            var discount = CalculateDiscount(order);

            // محاسبه مالیات
            var tax = CalculateTax(order);

            // قیمت نهایی
            return CalculateItemsTotal(order) - CalculateDiscount(order) + CalculateTax(order) + CalculateShippingCost(order);
            
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
