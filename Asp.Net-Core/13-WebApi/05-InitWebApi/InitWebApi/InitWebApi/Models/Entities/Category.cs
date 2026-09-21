using System.Collections.Generic;

namespace InitWebApi.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ToDo> ToDos { get; set; }
        //public int ToDoId { get; set; }

    }
}
