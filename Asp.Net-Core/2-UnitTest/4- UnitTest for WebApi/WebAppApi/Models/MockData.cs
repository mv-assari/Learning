using System.Collections;
using System.Collections.Generic;
using WebAppMvc.Models.Entities;

namespace WebAppMvc.Models
{
    public class MockData
    {
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{Id=1,Name="Iphone1",Description="In Category Mobile",Price=15000},
                new Product{Id=2,Name="Iphone2",Description="In Category Mobile",Price=25000},
                new Product{Id=3,Name="Iphone3",Description="In Category Mobile",Price=35000},
                new Product{Id=4,Name="Iphone4",Description="In Category Mobile",Price=45000},
            };

            return products;
        }

    }
}
