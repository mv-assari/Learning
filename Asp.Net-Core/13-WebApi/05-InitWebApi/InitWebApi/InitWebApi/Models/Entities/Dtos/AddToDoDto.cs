using System.Collections.Generic;

namespace InitWebApi.Models.Entities.Dtos
{
    public class AddToDoDto
    {
        public ToDoDto Todo { get; set; }
        public List<int> Categories { get; set; }
    }
}
