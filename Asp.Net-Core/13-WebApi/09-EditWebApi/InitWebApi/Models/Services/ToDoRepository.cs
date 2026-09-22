using InitWebApi.Models.Context;
using InitWebApi.Models.Entities;
using InitWebApi.Models.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InitWebApi.Models.Services
{
    public class ToDoRepository
    {
        private readonly DataBaseContext _context;

        public ToDoRepository(DataBaseContext context)
        {
            _context = context;
        }

        public List<ToDoDto> GetAll()
        {
            return _context.ToDos.Select(t => new ToDoDto
            {
                Id = t.Id,
                Text = t.Text,
                InsertTime = t.InsertTime,
                IsRemoved=t.IsRemoved
            }).ToList();
        }

        public ToDoDto Get(int id)
        {
            var todo = _context.ToDos.Find(id);
            return new ToDoDto
            {
                Id = todo.Id,
                InsertTime = todo.InsertTime,
                IsRemoved = todo.IsRemoved,
                Text = todo.Text
            };
        }

        public AddToDoDto Add(AddToDoDto todo)
        {
            
            ToDo newtoDo = new ToDo
            {
                Id = todo.Todo.Id,
                Text = todo.Todo.Text,
                InsertTime = DateTime.Now,
                IsRemoved = false
            };

            foreach (var item in todo.Categories)
            {
                var category = _context.Categories.Find(item);
                newtoDo.Categories.Add(category);
            }

            _context.ToDos.Add(newtoDo);
            _context.SaveChanges();

            return new AddToDoDto
            {
                Todo = new ToDoDto
                {
                    Id = newtoDo.Id,
                    InsertTime = newtoDo.InsertTime,
                    IsRemoved = newtoDo.IsRemoved,
                    Text = newtoDo.Text
                },
                Categories=todo.Categories
            };

        }

        public void Delete(int id)
        {
            //_context.ToDos.Remove(new ToDo { Id=id });
            var result= _context.ToDos.Find(id);
            result.IsRemoved = true;
            _context.SaveChanges();
        }

        public bool Edit(EditToDoDto editToDo)
        {
            var todo = _context.ToDos.Find(editToDo.Id);
            todo.Text = editToDo.Text;
            _context.SaveChanges();
            return true;
        }
    }
}
