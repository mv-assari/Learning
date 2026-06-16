using System;
using System.Collections.Generic;

namespace Replace_Method_with_Method_Object
{
    public class ReportBuilder_Before
    {
        public string BuildSalesReport(List<Sale> sales, int year, string region,
                                    bool includeDetails, bool includeCharts, string format)
        {
            // فیلتر کردن فروش‌ها
            var filteredSales = new List<Sale>();
            foreach (var sale in sales)
            {
                if (sale.Date.Year == year && sale.Region == region)
                    filteredSales.Add(sale);
            }

            // محاسبه آمار
            decimal totalAmount = 0;
            int totalCount = filteredSales.Count;
            decimal maxSale = 0;
            decimal minSale = decimal.MaxValue;
            var monthlyTotals = new Dictionary<int, decimal>();

            foreach (var sale in filteredSales)
            {
                totalAmount += sale.Amount;

                if (sale.Amount > maxSale)
                    maxSale = sale.Amount;
                if (sale.Amount < minSale)
                    minSale = sale.Amount;

                int month = sale.Date.Month;
                if (!monthlyTotals.ContainsKey(month))
                    monthlyTotals[month] = 0;
                monthlyTotals[month] += sale.Amount;
            }

            decimal average = totalCount > 0 ? totalAmount / totalCount : 0;

            // ساختن هدر گزارش
            string report = $"گزارش فروش - {year} - منطقه {region}\n";
            report += $"تعداد فروش: {totalCount}\n";
            report += $"فروش کل: {totalAmount:N0} ریال\n";
            report += $"میانگین: {average:N0} ریال\n";
            report += $"حداکثر: {maxSale:N0} ریال\n";
            report += $"حداقل: {(minSale == decimal.MaxValue ? 0 : minSale):N0} ریال\n";

            // اضافه کردن جزئیات ماهانه
            report += "\nفروش ماهانه:\n";
            for (int i = 1; i <= 12; i++)
            {
                if (monthlyTotals.ContainsKey(i))
                    report += $"ماه {i}: {monthlyTotals[i]:N0} ریال\n";
            }

            // اضافه کردن جزئیات اگه خواسته شده باشه
            if (includeDetails)
            {
                report += "\nجزئیات فروش‌ها:\n";
                foreach (var sale in filteredSales)
                {
                    report += $"- {sale.Date:yyyy/MM/dd}: {sale.Product} - {sale.Amount:N0} ریال\n";
                }
            }

            // اضافه کردن نمودار اگه خواسته شده باشه
            if (includeCharts)
            {
                report += "\nنمودار فروش ماهانه:\n";
                for (int i = 1; i <= 12; i++)
                {
                    if (monthlyTotals.ContainsKey(i))
                    {
                        int barLength = (int)(monthlyTotals[i] / 10000);
                        report += $"ماه {i:D2}: {new string('█', barLength)}\n";
                    }
                }
            }

            // فرمت‌بندی نهایی
            if (format == "HTML")
            {
                report = report.Replace("\n", "<br>");
                report = $"<html><body>{report}</body></html>";
            }

            return report;
        }
    }
    public class Sale
    {
        public DateTime Date { get; set; }
        public string Region { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }
    }
}
