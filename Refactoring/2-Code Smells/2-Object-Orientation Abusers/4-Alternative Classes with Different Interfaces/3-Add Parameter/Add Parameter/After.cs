using System;

namespace Add_Parameter
{
    public class After
    {
        public void Method()
        {
            // استفاده:
            var sender = new EmailSender();
            sender.SendEmail("user@test.com", "سلام", "خوبی؟");

            // حالا می‌خوایم اینم بشه:
            // sender.SendEmail("user@test.com", "admin@test.com", "سلام", "خوبی؟");
            // ولی فعلاً فقط ۳ تا پارامتر داره!
        }
    }

    public class EmailSender
    {

        public void SendEmail(string to, string subject, string body, string cc=null)
        {
            Console.WriteLine($"To: {to}");
            if(!string.IsNullOrEmpty(cc))
                Console.WriteLine($"CC: {cc}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
            Console.WriteLine("Email sent.");
        }

        [Obsolete("این متد استفاده نمیشود و منقضی شده است")]
        public void SendEmail(string to, string subject, string body)
        {
            // فرض کن حالا نیاز داریم cc هم اضافه کنیم
            Console.WriteLine($"To: {to}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
            Console.WriteLine("Email sent.");
        }
    }
}
