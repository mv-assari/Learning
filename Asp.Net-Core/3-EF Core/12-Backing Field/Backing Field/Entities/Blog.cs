using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog
    {
        private string _Url; // اگر نام یه این صورت باشه خودش متوجه میشه ولی اگه به شکل دیگه ای باشه باید کانفیگ برای معرفی انجام داد
        public int Id { get; set; }

        //[BackingField(nameof(_Url))] //باید ای اف روی این پروژه نصب باشه تا این خاصیت شناخته و اعمال بشه ولی خب قواعد نقض میشه
        public string Url 
        {
            get { return _Url; }
        }

        public void SetUrl(string url)
        {
            //در این قسمت بیزینس را اعمال میکنیم
            using(var client=new HttpClient())
            {
                var res=client.GetAsync(url).Result;
                res.EnsureSuccessStatusCode();
            }


            _Url = url;
        }
    }
}
