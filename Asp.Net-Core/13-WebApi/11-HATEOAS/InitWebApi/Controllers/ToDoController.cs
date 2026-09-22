using InitWebApi.Models.Entities;
using InitWebApi.Models.Entities.Dtos;
using InitWebApi.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InitWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoRepository _toDoRepository;

        public ToDoController(ToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public IActionResult Get()
        {
            var todoList = _toDoRepository.GetAll().Select(p => new ToDoItemDto
            {
                Id = p.Id,
                InsertTime = p.InsertTime,
                Text = p.Text,
                Links = new List<Links>()
                {
                    new Links
                    {
                        Href=Url.Action(nameof(Get),"ToDo",new{Id=p.Id},Request.Scheme),
                        Rel="Self",
                        Method="GET"
                    },

                    new Links
                    {
                        Href=Url.Action(nameof(Delete),"ToDo",new{Id=p.Id},Request.Scheme),
                        Rel="Delete",
                        Method="DELETE"
                    },

                    new Links
                    {
                        Href=Url.Action(nameof(Put),"ToDo",new{Id=p.Id},Request.Scheme),
                        Rel="Update",
                        Method="PUT"
                    },

                }
            }).ToList();
            return Ok(todoList);
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var todo = _toDoRepository.Get(id);
            return Ok(new ToDoItemDto
            {
                Id = todo.Id,
                InsertTime = todo.InsertTime,
                Text = todo.Text
            });
        }

        // POST api/<ToDoController>
        [HttpPost]
        public IActionResult Post([FromBody] ItemDto item)
        {
            var result = _toDoRepository.Add(new AddToDoDto
            {
                Todo = new ToDoDto
                {
                    Text = item.Text,
                }
            });
            string url = Url.Action(nameof(Get), "ToDo", new { Id = result.Todo.Id }, Request.Scheme);

            //return Created(url, result);
            return Created(url, true);

        }

        // PUT api/<ToDoController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] EditToDoDto editToDo)
        {
            var result = _toDoRepository.Edit(editToDo);
            return Ok(result);
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _toDoRepository.Delete(id);
            return Ok();
        }
    }
}
