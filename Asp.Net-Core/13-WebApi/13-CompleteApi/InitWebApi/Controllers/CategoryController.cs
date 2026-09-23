using InitWebApi.Models.Entities.Dtos;
using InitWebApi.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryRepository.Get(id));
        }

        [HttpPut]
        public IActionResult Put(CategoryDto categoryDto)
        {
            return Ok(_categoryRepository.Edit(categoryDto));
        }

        [HttpPost]
        public IActionResult Post(string name)
        {
            var result = _categoryRepository.AddCategory(name);
            return Created(Url.Action(nameof(Get), "Category", new { Id = result }, Request.Scheme), true);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_categoryRepository.Delete(id));
        }
    }
}
