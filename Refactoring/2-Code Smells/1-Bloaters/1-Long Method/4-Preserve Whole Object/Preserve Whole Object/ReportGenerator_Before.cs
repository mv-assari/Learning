using System;

namespace Preserve_Whole_Object
{
    public class ReportGenerator_Before
    {
        public string GenerateEmployeeReport(
        string firstName,
        string lastName,
        string employeeCode,
        string department,
        decimal baseSalary,
        decimal overtimePay,
        decimal tax,
        int workingDays,
        string phone,
        string email,
        string address)
        {
            var fullName = $"{firstName} {lastName}";
            var totalSalary = baseSalary + overtimePay - tax;
            var dailyRate = totalSalary / workingDays;

            var report = $"گزارش کارمند: {fullName}\n" +
                         $"کد: {employeeCode} - بخش: {department}\n" +
                         $"حقوق پایه: {baseSalary}, اضافه‌کار: {overtimePay}, مالیات: {tax}\n" +
                         $"حقوق کل: {totalSalary}, نرخ روزانه: {dailyRate:F0}\n" +
                         $"تلفن: {phone}, ایمیل: {email}\n" +
                         $"آدرس: {address}";

            return report;
        }
    }
}
