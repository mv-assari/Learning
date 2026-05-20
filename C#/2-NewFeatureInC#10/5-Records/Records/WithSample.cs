using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public class WithSample
    {
        public void Execute()
        {
            UserDto user = new UserDto();
            user.Id = 1;
            user.Name= "Test";
            user.Email = "mva@gmail.com";

            var user2 = user with { Name = "vahid" };//استفاده از کلمه کلیدی ویث در استراکت ها

            var person = new { Id = 2, Name = "mva" };
            var person2 = person with { Name = "Assari" };// استفاده از کلمه کلیدی ویث برای متغیرهای بی نام
        }

    }

    public struct UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
