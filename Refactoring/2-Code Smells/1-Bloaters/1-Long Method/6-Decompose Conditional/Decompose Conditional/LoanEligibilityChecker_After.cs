using System;

namespace Decompose_Conditional
{
    public class LoanEligibilityChecker_After
    {
        public string CheckEligibility(Customer customer, LoanRequest loan)
        {
            if (IsCreditWorthy(customer))
            {
                if (IsLoanAmountReasonable(customer,loan))
                {
                    if (HasHighDebtRatio(customer))
                    {
                        return "رد: نسبت بدهی بالا";
                    }
                    return "تایید: وام قابل پرداخت است";
                }
                return "رد: مبلغ یا مدت وام نامناسب";
            }
            return "رد: شرایط اولیه احراز نشد";

        }

        public bool IsCreditWorthy(Customer customer)
        {
            return (customer.CreditScore > 650 && customer.AnnualIncome > 500000000) ||
                (customer.IsEmployee && customer.YearsAtCurrentJob > 2 && customer.AnnualIncome > 300000000);
        }
        public bool IsLoanAmountReasonable(Customer customer,LoanRequest loan)
        {
            return loan.Amount < customer.AnnualIncome * 0.3m && loan.DurationMonths <= 60;
        }
        public bool HasHighDebtRatio(Customer customer)
        {
            return customer.HasActiveLoans && customer.TotalDebt > customer.AnnualIncome * 0.5m;
        }
    }

    public class Customer
    {
        public int CreditScore { get; set; }
        public decimal AnnualIncome { get; set; }
        public bool IsEmployee { get; set; }
        public int YearsAtCurrentJob { get; set; }
        public bool HasActiveLoans { get; set; }
        public decimal TotalDebt { get; set; }
    }

    public class LoanRequest
    {
        public decimal Amount { get; set; }
        public int DurationMonths { get; set; }
    }
}
