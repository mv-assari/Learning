
//چون در کلاس2 از رویداد کلاس1 استفاده شده است در پایان کار این متد کلاس1 هنوز باقی میماند و از حافظه پاک نمیشه
SomeOperation(new Class1());



void SomeOperation(Class1 class1)
{
    Class2 class2=new Class2(class1 );
    class2.DoSomthing();
    class2.Dispose(); //با این کار رفرنس آن پاک میشه و جی سی میتونه کلاس1 رو از حافظه پاک کنه
}


public class Class1
{
    public event EventHandler _onChange;
}

public class Class2:IDisposable
{
    Class1 _class1;

    public Class2(Class1 class1)
    {
        _class1 = class1;
        _class1._onChange += onChange;
    }

    public void onChange(object? sender,EventArgs args)
    {
        ///
    }

    public void DoSomthing()
    {
        Console.WriteLine("Class2.DoSomthing...");
    }

    public void Dispose()
    {
        _class1._onChange -= onChange; // رویدادی رو که اضافه کردی حذف کن
    }
}