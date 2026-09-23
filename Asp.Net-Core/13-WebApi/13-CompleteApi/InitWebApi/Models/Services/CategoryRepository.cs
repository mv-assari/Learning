using InitWebApi.Models.Context;
using InitWebApi.Models.Entities;
using InitWebApi.Models.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace InitWebApi.Models.Services
{
    public class CategoryRepository
    {
        private readonly DataBaseContext _context;

        public CategoryRepository(DataBaseContext context)
        {
            _context = context;
        }

        public List<CategoryDto> GetAll()
        {
            return _context.Categories.Select(p => new CategoryDto
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList(); 
        }

        public CategoryDto Get(int id)
        {
            var result= _context.Categories.Find(id); 
            return new CategoryDto { Id = result.Id, Name = result.Name };
        }

        public int AddCategory(string name)
        {
            Category category = new Category()
            {
                Name = name
            };

            _context.Categories.Add(category);
            _context.SaveChanges();
            return category.Id; 
        }

        public int Delete(int id)
        {
            _context.Categories.Remove(new Category { Id= id });
            return _context.SaveChanges();
        }

        public int Edit(CategoryDto categoryDto)
        {
            var category = _context.Categories.Find(categoryDto.Id);

            category.Name = categoryDto.Name;

            return _context.SaveChanges();
        }
    }
}
