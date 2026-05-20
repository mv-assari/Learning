
var r1 = new MyRecored(2, 3);
(int x, int y) = r1;

Console.WriteLine(r1);

var r2 = new Myr2(3,3);
//r2.a = 3;

var r2v2 = r2 with { a = 3 };//استفاده از کلمه کلیدی ویث برای کپی کردن تمام مقادیر قبلی و تغییرات در مقادبر خاص در متغیر جدید
public record class MyRecored(int a,int b); //کلمه کلیدی کلاس در این قسمت اختیاری هست

//--------------------------

// کلمه کلیدی استراکت در این قسمت اجباری هست
//اگر کلمه کلیدی فقط خواندنی را بگزاریم پراپرتی ها فقط هنگام تعریف قابلیت مقداردهی دارند
public readonly record struct Myr2(int a,int b); 


//کدهای زیر نمایانگر این هستند که رکورد ها قابلیت ارث بری را دارند
//با کلمه کلیدی سیلد میتوان قابلیت کلاس پدر را از کلاس فرزند گرفت
public record ProdcutDto
{
    public sealed override string ToString()
    {
        return "---";
    }
}

public record ProdcutDetailDto:ProdcutDto
{
   
}
