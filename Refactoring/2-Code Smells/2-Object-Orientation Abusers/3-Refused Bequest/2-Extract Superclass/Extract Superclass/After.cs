using System;

namespace Extract_Superclass
{
    public class After
    {
    }

    public abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public string GetContactInfo()
        {
            return $"{Name} - {Email}";
        }
    }

    public class Employee:Person
    {
        
        public decimal Salary { get; set; }

        

        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

    public class Customer:Person
    {

        public string CustomerType { get; set; }

        public decimal GetDiscount()
        {
            return CustomerType == "VIP" ? 0.2m : 0.05m;
        }
    }
}
