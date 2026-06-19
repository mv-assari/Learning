using System;

namespace Introduce_Null_Object
{
    public class After
    {
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual string GetDisplayName()
        {
            return Name;
        }

        public virtual string GetDisplayEmail()
        {
            return Email;
        }

        public virtual bool IsNull => false;
    }

    public class NullUser : User
    {
        public override bool IsNull 
        { 
            get { return true; } 
        }

        public override string GetDisplayName()
        {
            return "کاربر مهمان";
        }

        public override string GetDisplayEmail()
        {
            return "ایمیل نامشخص";
        }
    }

    public class UserService
    {
        public User GetUserById(int id)
        {
            // شبیه‌سازی - اگه id منفی باشه کاربر وجود نداره
            if (id < 0)
                return new NullUser();

            return new User { Name = "کاربر واقعی", Email = "user@test.com" };
        }

        public void ShowUserInfo(int id)
        {
            var user = GetUserById(id);

            Console.WriteLine($"نام: {user.GetDisplayName()}, ایمیل: {user.GetDisplayEmail()}");
        }
    }
}
