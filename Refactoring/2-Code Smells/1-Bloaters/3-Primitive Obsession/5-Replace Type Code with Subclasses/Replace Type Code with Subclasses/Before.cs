using System;

namespace Replace_Type_Code_with_Subclasses
{
    public class Before { }
    public class Vehicle
    {
        public const int CAR = 0;
        public const int TRUCK = 1;
        public const int MOTORCYCLE = 2;

        public int Type { get; set; }
        public string Model { get; set; }

        public decimal GetTollPrice()
        {
            switch (Type)
            {
                case CAR: return 5000;
                case TRUCK: return 15000;
                case MOTORCYCLE: return 2000;
                default: throw new Exception("نوع نامعتبر");
            }
        }

        public int GetMaxSpeed()
        {
            switch (Type)
            {
                case CAR: return 180;
                case TRUCK: return 100;
                case MOTORCYCLE: return 220;
                default: throw new Exception("نوع نامعتبر");
            }
        }
    }
}
