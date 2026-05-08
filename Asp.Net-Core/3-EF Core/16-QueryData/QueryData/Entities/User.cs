using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsRemoved { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
    }
}
