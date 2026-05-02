using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public long UserId { get; set; }
        //public long KeyId { get; set; }
        //public long KeyId2 { get; set; }
        public string NationalCode{ get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
