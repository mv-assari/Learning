using System;


namespace Preserve_Whole_Object
{
    public class ReportGenerator_After
    {
        public string GenerateEmployeeReport(Employee employee,SalaryDetail salaryDetail)
        {
            var fullName = $"{employee.FirstName} {employee.LastName}";
            var totalSalary = salaryDetail.BaseSalary + salaryDetail.OverTimePay -salaryDetail.Tax;
            var dailyRate = totalSalary / salaryDetail.WorkingDays;

            var report = $"گزارش کارمند: {fullName}\n" +
                         $"کد: {employee.EmployeeCode} - بخش: {employee.Department}\n" +
                         $"حقوق پایه: {salaryDetail.BaseSalary}, اضافه‌کار: {salaryDetail.OverTimePay}, مالیات: {salaryDetail.Tax}\n" +
                         $"حقوق کل: {totalSalary}, نرخ روزانه: {dailyRate:F0}\n" +
                         $"تلفن: {employee.Phone}, ایمیل: {employee.Email}\n" +
                         $"آدرس: {employee.Address}";

            return report;
        }
    }
    public class SalaryDetail
    {
        public decimal BaseSalary { get; set; }
        public decimal OverTimePay { get; set; }
        public decimal Tax { get; set; }
        public int WorkingDays { get; set; }
    }

    public class Employee
    {
        public string EmployeeCode { get; set; }
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

}
