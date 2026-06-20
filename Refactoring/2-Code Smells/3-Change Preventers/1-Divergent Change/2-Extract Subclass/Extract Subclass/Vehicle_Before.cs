using System;

namespace Extract_Subclass
{
    public class Vehicle_Before
    {
        // اطلاعات عمومی
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        // فقط برای ماشین‌ها
        public int NumberOfDoors { get; set; }
        public bool HasAirbag { get; set; }
        public string FuelType { get; set; }

        // فقط برای موتورها
        public bool HasSidecar { get; set; }
        public int EngineCC { get; set; }

        // فقط برای کامیون‌ها
        public decimal CargoCapacity { get; set; }
        public int NumberOfAxles { get; set; }

        // متدها
        public decimal CalculateTax()
        {
            if (FuelType == "Electric")
                return Price * 0.01m; // مالیات کم برای برقی
            if (EngineCC > 250)
                return Price * 0.05m; // موتورهای قوی
            if (CargoCapacity > 5000)
                return Price * 0.08m; // کامیون‌های سنگین
            return Price * 0.03m; // پیش‌فرض
        }
    }
}
