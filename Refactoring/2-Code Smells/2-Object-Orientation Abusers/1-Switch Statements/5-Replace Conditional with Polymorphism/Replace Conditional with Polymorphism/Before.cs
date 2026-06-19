using System;

namespace Replace_Conditional_with_Polymorphism
{
    public class Before
    {
    }

    public class Employee
    {
        public const int REGULAR = 0;
        public const int MANAGER = 1;
        public const int EXECUTIVE = 2;

        public int Type { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public decimal CalculateSalary()
        {
            switch (Type)
            {
                case REGULAR: return BaseSalary;
                case MANAGER: return BaseSalary * 1.5m;
                case EXECUTIVE: return BaseSalary * 2m + 5000000;
                default: throw new Exception("نوع نامعتبر");
            }
        }

        public int GetVacationDays()
        {
            switch (Type)
            {
                case REGULAR: return 15;
                case MANAGER: return 20;
                case EXECUTIVE: return 30;
                default: throw new Exception("نوع نامعتبر");
            }
        }
    }
}
