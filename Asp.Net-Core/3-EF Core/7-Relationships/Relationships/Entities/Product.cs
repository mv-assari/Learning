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
        public long CategoryId { get; set; }

        public ProductImage ProductImage { get; set; }

    }

    public class ProductImage
    {
        public long Id { get; set; }
        public byte[] Image { get; set; }
        public Product Product { get; set; }
        //public long ProductId { get; set; }
        public long FK_ProductId { get; set; }
    }
}
