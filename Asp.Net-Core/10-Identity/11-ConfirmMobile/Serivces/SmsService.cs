using System.Net;

namespace RunIdentity.Serivces
{
    public class SmsService
    {
        public void Send(string phoneNumber,string code)
        {
            //کاوه نگار سرویس پیامک داره 
            //برای استفاده از این کتابخونه باید اول اونو نصب کرد واز قبل هم باید در این سایت ثبت نام کرد که در این سایت یک قسمت تست و اشتراک رایگان داشت
            var api = new Kavenegar.KavenegarApi("3352557A4C6C66574E434F576A6E304C647232355338336747786F71377244736477325333475A704D734D3D");
            api.VerifyLookup(phoneNumber, code, "smsTest");

        }
    }
}
