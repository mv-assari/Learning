using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAppMvc.Models.Entities;
using WebAppMvc.Models.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: api/<ProductApiController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetAll());
        }

        // GET api/<ProductApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<ProductApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            var result = _productService.Add(value);

            return CreatedAtAction("Get", new { id = result.Id });
        }

        // DELETE api/<ProductApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product= _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.Remove(id);
            return Ok(true);
        }
    }
}
