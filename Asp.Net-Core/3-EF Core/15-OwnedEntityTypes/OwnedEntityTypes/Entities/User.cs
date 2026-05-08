using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Address Home { get; set; }
        public Address WorkPlace { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Alley { get; set; }
        public string Plaque { get; set; }
    }
}
