using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public int OrderNumber { get; set; }
    }
}
