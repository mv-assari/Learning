using System;

namespace Replace_Parameter_with_Method_Call
{
    public class Before
    {
    }

    public class ReportGenerator
    {
        public string GenerateReport(string companyName, string companyAddress,
                                      string companyPhone, string currentDate)
        {
            return $"گزارش {companyName}\n" +
                   $"آدرس: {companyAddress}\n" +
                   $"تلفن: {companyPhone}\n" +
                   $"تاریخ: {currentDate}";
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
