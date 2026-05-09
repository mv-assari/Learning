using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Post> Posts { get; set; }
    }

    //یا این خاصیت میتوان کلاس بدون کلیداصلی تعریف کرد
    //[keyless]
    public class KeylessEntity
    {
        //قابلیت جدید که قبلا فقط از طریق فلونت ای پی آی بود
        //[Backingfield("")]

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Tonage { get; set; }
    }

    //امکان استفاده از کلاس آی پی آدرس 
    //قابلیت ایندکس گذاری از طریق خاصیت ها
    //[Index(nameof(IPAddress),IsUnique=true)]
    public class Server
    {
        public int Id { get; set; }
        public IPAddress IPAddress { get; set; }
    }
}
