using System;

namespace Replace_Type_Code_with_Class
{
    public class Before { }
    public class Ticket
    {
        // کد نوع تیکت
        public const int BUG = 0;
        public const int FEATURE = 1;
        public const int TASK = 2;
        public const int IMPROVEMENT = 3;

        public int Type { get; set; }
        public string Title { get; set; }

        public decimal GetEstimateHours()
        {
            switch (Type)
            {
                case BUG: return 4;
                case FEATURE: return 20;
                case TASK: return 8;
                case IMPROVEMENT: return 12;
                default: throw new Exception("نوع نامعتبر");
            }
        }
    }
}
