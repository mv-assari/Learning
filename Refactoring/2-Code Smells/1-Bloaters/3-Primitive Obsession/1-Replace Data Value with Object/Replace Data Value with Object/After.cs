using System;
using System.Reflection.Metadata.Ecma335;

namespace Replace_Data_Value_with_Object
{
    public class After {}

    public class Employee
    {
        public Email Email { get; set; }
        public Mony Salary { get; set; }
    }

    public class Email
    {
        public Email(string value)
        {
            if(string.IsNullOrEmpty(value) || !value.Contains("@"))
                throw new Exception("ایمیل نامعتبر است");
            Value = value;
        }

        public string Value { get; }

        public override string ToString()
        {
            return Value;
        }
    }

    public class Money
    {
        public Money(decimal salary)
        {
            if (salary<0)
                throw new Exception("حقوق نمی‌تواند منفی باشد");
            Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString()
        {
            return string.Format("{0:N0} تومان",Salary);
        }

    }

    public class PayrollService
    {
        public void SendSalarySlip(Employee emp)
        {
            Console.WriteLine($"فیش حقوقی به {emp.Email} ارسال شد: {emp.Salary}");
        }
    }
}
