using System;

namespace Parameterize_Method
{
    public class After
    {
    }

    public class TaxCalculator
    {
        public decimal CalculateTax(decimal amount,decimal rate)
        {
            return amount * rate;
        }    
    }

}
