using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitWebApi.Controllers
{
    [Route("api/ToDo/{ToDoId}/Categories/{CategoryId}")]
    [ApiController]
    public class ToDoCategoryController : ControllerBase
    {
        [HttpPost]
        public IActionResult POST(int ToDoId,int CategoryId)
        {
            return Ok();
        }
    }
}
