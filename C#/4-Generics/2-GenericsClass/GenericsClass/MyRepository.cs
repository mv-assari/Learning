using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    public class MyRepository
    {

        public ResultDto<List<ProductDto>> GetProducts()
        {
            return new ResultDto<List<ProductDto>>() 
            {
                Succeed = true,
                Data=new List<ProductDto>()
            };
        }

        public ResultDto<List<OrderDto>> GetOrders()
        {
            return new ResultDto<List<OrderDto>>()
            {
                Succeed= true,
                Data=new List<OrderDto>()
            };
        }

    }

    public class ResultDto<T>
    {
        public bool Succeed { get; set; }
        public string Message { get; set; }
        public  T Data { get; set; }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OrderDto
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
    }
}
