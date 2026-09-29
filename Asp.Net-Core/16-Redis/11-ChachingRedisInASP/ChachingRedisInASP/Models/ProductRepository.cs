using ChachingRedisInASP.Models.Dto;
using System.Collections.Generic;
using System.Threading;

namespace ChachingRedisInASP.Models
{
    public interface IProductRepository
    {
        public HomePageDto GetHomePageProducts();
    }
    public class ProductRepository: IProductRepository
    {
        public HomePageDto GetHomePageProducts()
        {
            Thread.Sleep(3000);
            return new HomePageDto
            {
                BestProducts = new BestProduct()
                {
                    Products = new List<ProductDto>
                    {
                        new ProductDto {Id=1,Name="آموزش اصولی solid" },
                        new ProductDto {Id=2,Name="آموزش الگوهای طراحی" },
                    }
                },
                LastProducts=new LastProduct()
                {
                    Products=new List<ProductDto>
                    {
                        new ProductDto {Id=3,Name="آموزش میکروسرویس" },
                        new ProductDto {Id=4,Name="آموزش DDD" },
                        new ProductDto {Id=5,Name="آموزش پیشرفته سی شارپ" },
                    }
                }
            };
        }
    }
}
