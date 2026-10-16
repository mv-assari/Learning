using Application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
    public interface IDiscountService
    {
        List<CatlogItemDto> GetCatalogItems(string searchKey);
    }

    public class DiscountService : IDiscountService
    {
        private readonly IDataBaseContext context;

        public DiscountService(IDataBaseContext context)
        {
            this.context = context;
        }

        public List<CatlogItemDto> GetCatalogItems(string searchKey)
        {
            if (!string.IsNullOrEmpty(searchKey))
            {
                var data = context.catalogItems
                    .Where(p => p.Name.Contains(searchKey))
                    .Select(p => new CatlogItemDto
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();
                return data;
            }
            else
            {
                var data = context.catalogItems
                    .OrderByDescending(p => p.Id)
                    .Take(10)
                    .Select(p => new CatlogItemDto
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();
                return data;
            }
        }
    }

    public class CatlogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
