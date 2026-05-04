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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int Score { get; set; }
        public DateTime InsertDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    public class Order
    {
        public long Id { get; set; }
        public string OrderNumber { get; set; }
        public User User { get; set; }
    }
}
