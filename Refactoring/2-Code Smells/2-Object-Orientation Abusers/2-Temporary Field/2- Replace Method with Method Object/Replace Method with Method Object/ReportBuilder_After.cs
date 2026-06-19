using System;
using System.Collections.Generic;

namespace Replace_Method_with_Method_Object
{
    public class ReportBuilder_After
    {
        public string BuildSalesReport(List<Sale> sales, Filter filters, OptionReport options)
        {
            return new SalesReportBuilder(sales, options, filters).Build();
        }
    }

    public class SalesReportBuilder
    {
        #region Fields
        private readonly List<Sale> _sales;
        private readonly OptionReport _options;
        private readonly Filter _filters;

        private List<Sale> _filteredSales;
        private decimal _totalAmount;
        private int _totalCount;
        private decimal _maxSale;
        private decimal _minSale;
        private Dictionary<int, decimal> _monthlyTotals;
        private decimal _average;
        #endregion

        public SalesReportBuilder(List<Sale> sales, OptionReport options, Filter filters)
        {
            _sales = sales;
            _options = options;
            _filters = filters;
        }

        public string Build()
        {
            FilterSales();
            CalculateStatistics();
            var report = BuildHeader();
            report += BuildMonthlySection();
            report += BuildDetails();
            report += BuildCharts();
            report = FormatReport(report);

            return report;
        }

        public void FilterSales()
        {
            _filteredSales = new List<Sale>();
            foreach (var sale in _sales)
            {
                if (sale.Date.Year == _filters.Year && sale.Region == _filters.Region)
                    _filteredSales.Add(sale);
            }
        }

        public void CalculateStatistics()
        {
            // محاسبه آمار
            _totalAmount = 0;
            _totalCount = _filteredSales.Count;
            _maxSale = 0;
            _minSale = decimal.MaxValue;
            _monthlyTotals = new Dictionary<int, decimal>();

            foreach (var sale in _filteredSales)
            {
                _totalAmount += sale.Amount;

                if (sale.Amount > _maxSale)
                    _maxSale = sale.Amount;
                if (sale.Amount < _minSale)
                    _minSale = sale.Amount;

                int month = sale.Date.Month;
                if (!_monthlyTotals.ContainsKey(month))
                    _monthlyTotals[month] = 0;
                _monthlyTotals[month] += sale.Amount;
            }

            _average = _totalCount > 0 ? _totalAmount / _totalCount : 0;
        }

        public string BuildHeader()
        {
            return $"گزارش فروش - {_filters.Year} - منطقه {_filters.Region}\n" +
                   $"تعداد فروش: {_totalCount}\n" +
                   $"فروش کل: {_totalAmount:N0} ریال\n" +
                   $"میانگین: {_average:N0} ریال\n" +
                   $"حداکثر: {_maxSale:N0} ریال\n" +
                   $"حداقل: {(_minSale == decimal.MaxValue ? 0 : _minSale):N0} ریال\n";
        }

        public string BuildMonthlySection()
        {
            var section = "\nفروش ماهانه:\n";
            for (int i = 1; i <= 12; i++)
            {
                if (_monthlyTotals.ContainsKey(i))
                    section += $"ماه {i}: {_monthlyTotals[i]:N0} ریال\n";
            }
            return section;
        }

        public string BuildDetails()
        {
            // اضافه کردن جزئیات اگه خواسته شده باشه
            if (!_options.IncludeDetails)
                return "";

            var detail = "\nجزئیات فروش‌ها:\n";
            foreach (var sale in _filteredSales)
            {
                detail += $"- {sale.Date:yyyy/MM/dd}: {sale.Product} - {sale.Amount:N0} ریال\n";
            }
            return detail;
        }

        public string BuildCharts()
        {
            // اضافه کردن نمودار اگه خواسته شده باشه
            if (!_options.IncludeCharts)
                return "";
            var chart = "\nنمودار فروش ماهانه:\n";
            for (int i = 1; i <= 12; i++)
            {
                if (_monthlyTotals.ContainsKey(i))
                {
                    int barLength = (int)(_monthlyTotals[i] / 10000);
                    chart += $"ماه {i:D2}: {new string('█', barLength)}\n";
                }
            }
            return chart;
        }

        public string FormatReport(string report)
        {
            if (_options.Format == "HTML")
            {
                report = report.Replace("\n", "<br>");
                report = $"<html><body>{report}</body></html>";
            }
            return report;
        }
    }

    public class Filter
    {
        public int Year { get; set; }
        public string Region { get; set; }
    }
    public class OptionReport
    {
        public bool IncludeDetails { get; set; }
        public bool IncludeCharts { get; set; }
        public string Format { get; set; }
    }
    public class Sale
    {
        public DateTime Date { get; set; }
        public string Region { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }
    }
}
