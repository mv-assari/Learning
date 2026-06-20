using System;

namespace Move_Field
{
    public class After
    {
    }

    public class Customer
    {
        public string Name { get; set; }
        
    }

    public class LoanCalculator
    {
        public decimal InterestRate { get; set; } = 0.05m; 
        public Customer Customer { get; set; }

        public decimal CalculateInterest(decimal amount)
        {
            return amount * InterestRate; // فقط اینجا استفاده میشه
        }
    }
}
