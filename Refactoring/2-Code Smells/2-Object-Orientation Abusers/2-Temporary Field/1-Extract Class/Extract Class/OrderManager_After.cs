using System;
using System.Collections.Generic;

namespace Extract_Class
{
    public class OrderManager_After
    {
        public CustomerInfo Customer { get; set; }
        public OrderDetails Order { get; set; }
        public PaymentInfo Payment { get; set; }
        public ShippInfo Shipp { get; set; }

    }

    public class CustomerInfo
    {
        // اطلاعات مشتری
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }

        public void UpdateCustomerInfo(string name, string email) { /* ... */ }
        public void SendConfirmationEmail() { /* ... */ }
    }

    public class OrderDetails
    {
        // اطلاعات سفارش
        public List<OrderItem> Items { get; set; } = new();
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        public void AddItem(string name, decimal price, int quantity) { /* ... */ }
        public void RemoveItem(string name) { /* ... */ }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
                total += item.Price * item.Quantity;
            return total;
        }
    }

    public class OrderItem
    {
        //اطلاعات جزئیات سفارش
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class PaymentInfo
    {
        // اطلاعات پرداخت
        public string PaymentMethod { get; set; }
        public string CardNumber { get; set; }
        public decimal Amount { get; set; }

        public void ProcessPayment() { /* ... */ }
        public void RefundPayment() { /* ... */ }
    }

    public class ShippInfo
    {
        // اطلاعات ارسال
        public string ShippingAddress { get; set; }
        public string TrackingCode { get; set; }
        public DateTime? ShippedDate { get; set; }

        public void ShipOrder() { /* ... */ }
        public void UpdateTracking(string code) { /* ... */ }
        public void SendShippingNotification() { /* ... */ }
    }
}
