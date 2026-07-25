using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RunIdentity.Serivces
{
    public class EmailService
    {
        public Task Execute(string userEmile,string body,string subject)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 50000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("mv.assari.73@gmail.com", "leds luwu daze jybv"/*در این قسمت به جای رمزعبور ایمیل از بخش https://myaccount.google.com/apppasswords یک رمز عبور میگیریم و دراینجا استفاده میکنیم*/);

            MailMessage message = new MailMessage("mv.assari.73@gmail.com",userEmile,subject,body);
            message.IsBodyHtml = true;
            message.BodyEncoding=UTF8Encoding.UTF8;
            message.DeliveryNotificationOptions=DeliveryNotificationOptions.OnSuccess;

            client.Send(message);
            return Task.CompletedTask;
        }
    }
}
