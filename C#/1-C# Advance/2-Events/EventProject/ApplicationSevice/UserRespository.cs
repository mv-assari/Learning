using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSevice
{
    public class UserDataEventArgs : EventArgs
    {
        public string Email { get; set; }
    }

    public class UserRespository
    {
        //اگر برای مثال ایونت آرکگز تغییر داشتیم باید مثل دو خط پایین عمل کنیم
        public delegate void UserRegistredEventHandler(object source,UserDataEventArgs args); //اگر همین ساختار رو داریم میتونیم به صورت زیر عمل کنید
        public event UserRegistredEventHandler UserRegistred;

        //public event EventHandler UserRegistred; //اما اگر تغییری نداشتیم به جای دوخط بالا از همین خط استفاده میکنیم

        public virtual void OnUserRegistred(UserDataEventArgs args)
        {
            UserRegistred?.Invoke(this, args);
        }

        public void RegisterUser(string email,string password)
        {
            //کدهای ثبت نام کاربر جدید

            Console.WriteLine($"User Registered at:{DateTime.Now.ToLongTimeString()}");

            OnUserRegistred(new UserDataEventArgs { Email=email});
        }
    }
}
