using System;

namespace Replace_Conditional_with_Polymorphism
{
    public class After
    {
        public void MethodTest()
        {
            List<Employee> employees = new()
            {
                new Regular { Name = "علی", BaseSalary = 10000000 },
                new Manager { Name = "مریم", BaseSalary = 15000000 },
                new Executive { Name = "حسین", BaseSalary = 20000000 }
            };

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name}: حقوق {emp.CalculateSalary():N0}, مرخصی {emp.GetVacationDays()} روز");
            }

            // خروجی:
            // علی: حقوق 10,000,000, مرخصی 15 روز
            // مریم: حقوق 22,500,000, مرخصی 20 روز
            // حسین: حقوق 45,000,000, مرخصی 30 روز
        }
    }

    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public abstract decimal CalculateSalary();

        public abstract int GetVacationDays();

    }

    public class Regular : Employee
    {
        public override decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public override int GetVacationDays()
        {
            return 15;
        }
    }
    public class Manager : Employee
    {
        public override decimal CalculateSalary()
        {
            return BaseSalary * 1.5;
        }

        public override int GetVacationDays()
        {
            return 20;
        }
    }
    public class Executive : Employee
    {
        public override decimal CalculateSalary()
        {
            return BaseSalary * 2m + 5000000;
        }

        public override int GetVacationDays()
        {
            return 30;
        }
    }
}
