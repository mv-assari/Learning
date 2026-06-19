using System;
using System.Collections.Generic;

namespace Extract_Class
{
    public class OrderManager_Before
    {
        // اطلاعات مشتری
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }

        // اطلاعات سفارش
        public List<OrderItem> Items { get; set; } = new();
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // اطلاعات پرداخت
        public string PaymentMethod { get; set; }
        public string CardNumber { get; set; }
        public decimal Amount { get; set; }

        // اطلاعات ارسال
        public string ShippingAddress { get; set; }
        public string TrackingCode { get; set; }
        public DateTime? ShippedDate { get; set; }

        // متدها
        public void AddItem(string name, decimal price, int quantity) { /* ... */ }
        public void RemoveItem(string name) { /* ... */ }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
                total += item.Price * item.Quantity;
            return total;
        }

        public void ProcessPayment() { /* ... */ }
        public void RefundPayment() { /* ... */ }

        public void ShipOrder() { /* ... */ }
        public void UpdateTracking(string code) { /* ... */ }

        public void SendConfirmationEmail() { /* ... */ }
        public void SendShippingNotification() { /* ... */ }

        public void UpdateCustomerInfo(string name, string email) { /* ... */ }
    }
}
