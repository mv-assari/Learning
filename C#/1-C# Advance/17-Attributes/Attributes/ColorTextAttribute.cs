using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class,AllowMultiple =false)]//این کار برای محدود سازی قابلیت استفاده از ایتریبیوت هست
    public class ColorTextAttribute:Attribute
    {
        public ColorTextAttribute(ConsoleColor color)
        {
            Color = color;
        }

        public ColorTextAttribute()
        {
            Color = ConsoleColor.Red;
        }

        public ConsoleColor Color { get; set; }
    }
}
