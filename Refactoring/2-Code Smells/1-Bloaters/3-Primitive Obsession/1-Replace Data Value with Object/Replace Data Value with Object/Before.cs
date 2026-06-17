using System;

namespace Replace_Data_Value_with_Object
{
    public class Before { }

    public class Employee
    {
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }

    public class PayrollService
    {
        public void SendSalarySlip(Employee emp)
        {
            // اعتبارسنجی پراکنده ایمیل
            if (string.IsNullOrEmpty(emp.Email) || !emp.Email.Contains("@"))
                throw new Exception("ایمیل نامعتبر است");

            // اعتبارسنجی پراکنده حقوق
            if (emp.Salary < 0)
                throw new Exception("حقوق نمی‌تواند منفی باشد");

            // فرمت نمایش حقوق
            string formattedSalary = string.Format("{0:N0} تومان", emp.Salary);

            Console.WriteLine($"فیش حقوقی به {emp.Email} ارسال شد: {formattedSalary}");
        }
    }
}
