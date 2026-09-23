using InitWebApi.Models.Entities.Dtos;
using InitWebApi.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitWebApi.Controllers
{
    //[Route("api/v{version:apiVersion}/[controller]")]

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// لیست اطلاعات دسته بندی را دریافت میکند
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryRepository.GetAll());
        }

        /// <summary>
        /// اطلاعات دسته بندی را دریافت میکند
        /// </summary>
        /// <param name="id">شناسه دسته بندی</param>
        /// <returns></returns>
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
