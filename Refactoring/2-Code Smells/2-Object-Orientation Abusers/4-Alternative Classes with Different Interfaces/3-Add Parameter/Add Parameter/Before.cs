using System;

namespace Add_Parameter
{
    public class Before
    {
    }

    public class EmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            // فرض کن حالا نیاز داریم cc هم اضافه کنیم
            Console.WriteLine($"To: {to}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
            Console.WriteLine("Email sent.");
        }
}

// استفاده:
var sender = new EmailSender();
sender.SendEmail("user@test.com", "سلام", "خوبی؟");

// حالا می‌خوایم اینم بشه:
// sender.SendEmail("user@test.com", "admin@test.com", "سلام", "خوبی؟");
// ولی فعلاً فقط ۳ تا پارامتر داره!
}
