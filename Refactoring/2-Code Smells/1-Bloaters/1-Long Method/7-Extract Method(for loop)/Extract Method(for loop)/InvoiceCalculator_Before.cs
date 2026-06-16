using System;
using System.Collections.Generic;

namespace Extract_Method_for_loop_
{
    public class InvoiceCalculator_Before
    {
        public decimal CalculateTotal(Invoice invoice)
        {
            decimal total = 0;

            // این حلقه رو Extract کن
            foreach (var item in invoice.Items)
            {
                decimal itemTotal = item.Price * item.Quantity;

                if (item.IsTaxable)
                    itemTotal += itemTotal * 0.09m;

                if (item.Category == "Electronics")
                    itemTotal += 5000; // بیمه اجباری

                total += itemTotal;
            }

            // تخفیف کل
            if (total > 1000000)
                total *= 0.9m;

            return total;
        }
    }

    public class Invoice
    {
        public List<InvoiceItem> Items { get; set; } = new();
    }

    public class InvoiceItem
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsTaxable { get; set; }
        public string Category { get; set; }
    }
}
