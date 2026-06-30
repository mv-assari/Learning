using ConfigRazorPages.Data;
using ConfigRazorPages.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConfigRazorPages.Services
{
    public interface IProductService
    {
        int Add(ProductDto product);
        int Delete(int id);
        ProductDto Find(int id);
        List<ProductDto> List();
        ProductDto Edit(ProductDto product);
        List<ProductDto> Search(string name);
    }

    public class ProductService : IProductService
    {
        private readonly DataBaseContext _context;

        public ProductService(DataBaseContext context)
        {
            _context = context;
        }

        public int Add(ProductDto product)
        {
            _context.Products.Add(new Product
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
            });

            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            _context.Products.Remove(new Product
            {
                Id = id
            });

            return _context.SaveChanges();
        }

        public ProductDto Edit(ProductDto product)
        {
            var entity = _context.Products.Find(product.Id);
            entity.Description = product.Description;
            entity.Name= product.Name;
            entity.Price = product.Price;
            _context.SaveChanges();
            return product;
        }

        public ProductDto Find(int id)
        {
            var entity= _context.Products.Find(id);
            return new ProductDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
            };
        }

        public List<ProductDto> List()
        {
            return _context.Products.OrderByDescending(p=>p.Id).Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
            }).ToList();
        }

        public List<ProductDto> Search(string name)
        {
            return _context.Products.Where(p=>p.Name.Contains(name)).OrderByDescending(p=>p.Id).Select(p=>new ProductDto
            {
                Id=p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,

            }).ToList();
        }
    }
}
