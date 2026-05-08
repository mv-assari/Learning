using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tag
    {
        public long Id { get; set; }
        public string TagText { get; set; }

        public virtual Post Post { get; set; }
        public long PostId { get; set; }
    }
}
