// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
void Test(bool condition ,[CallerArgumentExpression("condition")] string data=null) //توسط این قابلیت میتوان دیتای ورودی رو هم لاگ کرد
{
    Console.WriteLine($"condition:{condition}");
    Console.WriteLine($"data:{data}");
}



int a = 1;
int b = 1;
Test(a == b);
Test(true);
Test(1 == 1);

Console.ReadLine();

