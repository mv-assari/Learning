using System;

namespace Replace_Parameter_with_Explicit_Methods
{
    public class Before
    {
    }

    public class Calculator
    {
        public int DoOperation(string operation, int a, int b)
        {
            if (operation.Equals("add"))
                return a + b;

            if (operation.Equals("subtract"))
                return a - b;

            if (operation.Equals("multiply"))
                return a * b;

            if (operation.Equals("divide"))
            {
                if (b == 0)
                    throw new DivideByZeroException();
                return a / b;
            }

            throw new Exception("عملیات نامعتبر");
        }
    }
}
