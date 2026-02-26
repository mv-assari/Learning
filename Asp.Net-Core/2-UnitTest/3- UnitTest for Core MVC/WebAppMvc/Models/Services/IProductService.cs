using System;
using System.Collections.Generic;
using System.Linq;
using WebAppMvc.Models.Entities;

namespace WebAppMvc.Models.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product Add(Product product);
        Product GetById(long id);
        void Remove(long id);
    }

    public class ProductService : IProductService
    {
        private readonly DataBaseContext _context;
        public ProductService(DataBaseContext context)
        {
            _context = context;
        }
        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(long id)
        {
            return _context.Products.Find(id);
        }

        public void Remove(long id)
        {
            var product= _context.Products.Find(id);
            _context.Products.Remove(product);
        }
    }
}
