using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        //public long CatagoryId { get; set; } اگر این پراپرتی را نداشته باشیم به صورت شدوپراپرتی در دیتابیس به صورت خودکار ایجاد میشود

    }
}
