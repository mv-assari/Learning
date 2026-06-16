using Microsoft.VisualBasic.FileIO;
using System;

namespace Extract_Subclass
{
    public class Vehicle_After
    {

    }

    public class Vehicle
    {
        // اطلاعات عمومی
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public virtual decimal CalculateTax()
        {
            return Price * 0.03m; // پیش‌فرض
        }
    }

    public class Car : Vehicle
    {
        // فقط برای ماشین‌ها
        public int NumberOfDoors { get; set; }
        public bool HasAirbag { get; set; }
        public string FuelType { get; set; }

        public override decimal CalculateTax()
        {
            if (FuelType == "Electric")
                return Price * 0.01m; // مالیات کم برای برقی
            return Price * 0.03m; // پیش‌فرض 
        }
    }

    public class Motorcycle : Vehicle
    {
        // فقط برای موتورها
        public bool HasSidecar { get; set; }
        public int EngineCC { get; set; }

        public override decimal CalculateTax()
        {
            if (EngineCC > 250)
                return Price * 0.05m; // موتورهای قوی
            return Price * 0.03m; // پیش‌فرض
        }
    }

    public class Truck : Vehicle
    {
        // فقط برای کامیون‌ها
        public decimal CargoCapacity { get; set; }
        public int NumberOfAxles { get; set; }

        public override decimal CalculateTax()
        {
            if (CargoCapacity > 5000)
                return Price * 0.08m; // کامیون‌های سنگین
            return Price * 0.03m; // پیش‌فرض
        }
    }
}
