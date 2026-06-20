using System;

namespace Extract_Superclass
{
    public class Before
    {
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }

        public string GetContactInfo()
        {
            return $"{Name} - {Email}";
        }

        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string CustomerType { get; set; }

        public string GetContactInfo()
        {
            return $"{Name} - {Email}";
        }

        public decimal GetDiscount()
        {
            return CustomerType == "VIP" ? 0.2m : 0.05m;
        }
    }
}
