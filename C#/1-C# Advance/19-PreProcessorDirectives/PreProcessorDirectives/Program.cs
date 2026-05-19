#undef DEBUG
using System;
using System.Diagnostics;

namespace PreProcessorDirectives
{
    
    /*در این قسمت نیز میتوان تعریفات خود را انجام داد
    <Project Sdk="Microsoft.NET.Sdk">

      <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net5.0</TargetFramework>
	     <DefineConstants> DEBUG ; TEST </DefineConstants> در این قسمت میتوانیم محیط های مختلفی را ایجاد کنیم
      </PropertyGroup>

    </Project> 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            #pragma warning disable 0168 //برای فعال کردن نادیده گرفتن هشدارها که حتی میتوان نوع آن را مشخص کرد یا حتی محدوده آن را نیز مشخص کرد
            int number;//این خط هشدار نادیده گرفته شد
            #pragma warning restore 0168
            string name; // این خط هنوز هشدار دارد چون خارج از محدوده هست


            #region connect to database
            //
            //
            //
            //
            #endregion

            #if DEBUG
                Console.WriteLine("is Debug");
            #else
                Console.WriteLine("is Not Debug");
            #endif

            Console.ReadLine();
        }
    }

    [Conditional("DEBUG")]//این اتریبیوت فقط در این محیط اجرا شود
    public class AttrAttribute : Attribute
    {

    }
}
