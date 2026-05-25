using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakReference
{
    public class Contact
    {
        System.WeakReference Weak;
        public Contact()
        {
            Weak = new System.WeakReference(null);
        }

        public List<string> GetContacts()
        {
            //چون از قبل دیتا رو گرفته بود ولی با اینکه کار متد و کلاس تموم بود و جی سی باید اونو از حافظه پاک میکرد ولی با این روش دیگه دوباره پردازش سنگین اتفاق نمی افته
            var data=Weak.Target as List<string>; 
            if(data is null)
            {
                Weak.Target =LoadData();
                data=Weak.Target as List<string>;
            }

            return data;
        }

        public List<string> LoadData()
        {
            return new List<string>
            {
                "ali",
                "vahid",
                "fatemeh"
            };
        }

    }
}
