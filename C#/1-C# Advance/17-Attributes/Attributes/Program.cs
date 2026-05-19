using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Attributes
{

    //به صورت درونی ماکروسافت یکسری ایریبیوت تعریف کرده که کار ما راحت تر باشه
    //برای دسترسی به اونها در قسمت آبجکت بروزر کلمه اتریبیوت رو سرچ میکنیم و تمام اون هارو میتونیم ببینیم و اطلاعاتی کسب کنیم و استفاده کنیم
    internal class Program
    {
        static void Main(string[] args)
        {
            //MessageBox.ShowMessageInConsole("salam azizam",1);
            //MessageBox.ShowMessageBox(0, "این یک پیغام تستی است!", "پیغام",0);


            User user1=new User(1,"vahid","Assari") ;
            User user2=new User(2,"vahid2","Assari2") ;

            Product product = new Product(1, "shelang", "abyari", 30000);

            user1.Print();
            user2.Print();
            product.Print();


            Console.ReadLine();
        }

    }

    public class MessageBox
    {
        [DllImport("user32.dll",EntryPoint ="MessageBox",CharSet =CharSet.Unicode)] // استفاده از یک دی ال ال خارجی به واسطه اتریبیوت ها
        public static extern int ShowMessageBox(int hWnd, string message, string caption, uint type);

        //اگراز تورو استفاده کنیم اون هشدار تبدیل به خطا میشه و کاربر اجبارا باید از نسخه جدید استفاده کنه
        [Obsolete("این متد در ورژن بعدی حذف میشه و از ورژن جدید استفاده کنید",true)] //برای اینکه بتوانیم به استفاده کنندگان اعلام کنیم نسخه قدیمی شده
        public static void ShowMessageInConsole(string message)
        {
            Console.WriteLine("Show meesage version 1");
        }

        public static void ShowMessageInConsole(string message,int type)
        {
            Console.WriteLine("Show meesage version 2");
        }
    }
}
