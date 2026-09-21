using System;

namespace InitWebApi.Models.Entities.Dtos
{
    public class ToDoDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime InsertTime { get; set; }
        public bool IsRemoved { get; set; }
    }
}
