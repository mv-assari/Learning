using System;

namespace Replace_Parameter_with_Method_Call
{
    public class After
    {
    }

    public class ReportGenerator
    {
        public string GenerateReport(Company company)
        {
            return $"گزارش {company.Name}\n" +
                   $"آدرس: {company.Address}\n" +
                   $"تلفن: {company.Phone}\n" +
                   $"تاریخ: {company.GetCurrentDate()}";
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}
