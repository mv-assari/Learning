using System;

namespace Introduce_Null_Object
{
    public class Before
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

        public virtual bool IsNull => false;
    }

    public class UserService
    {
        public User GetUserById(int id)
        {
            // شبیه‌سازی - اگه id منفی باشه کاربر وجود نداره
            if (id < 0)
                return null;

            return new User { Name = "کاربر واقعی", Email = "user@test.com" };
        }

        public void ShowUserInfo(int id)
        {
            var user = GetUserById(id);

            // چک null توی همه جا پخش شده
            string displayName;
            if (user == null)
            {
                displayName = "کاربر مهمان";
            }
            else
            {
                displayName = user.GetDisplayName();
            }

            string email;
            if (user == null)
            {
                email = "ایمیل نامشخص";
            }
            else
            {
                email = user.Email;
            }

            Console.WriteLine($"نام: {displayName}, ایمیل: {email}");
        }
    }
}
