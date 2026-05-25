
//Method(); // به صورت متد استفاده کنیم که به محض از بین رفتن رفرنس خودش به دنبال حذف شی ایجاد شده باشد
//GC.Collect(); //این حالت توصیه نمشود چون سربار دارد مگر در حالت های بسیار خاص

//TestClass test = new TestClass(); //به این صورت میتوان استفاده کرد
//test.Run();
//test.Dispose();

using (TestClass test = new TestClass()) //یک روش دیگر
{
    test.Run();
}



Console.ReadLine();

void Method()
{
    TestClass test=new TestClass();
    test.Run();
}

//------------------------

public class TestClass:IDisposable //هر کلاسی یا کتابخانه یا ... که اینترفیس  را پیاده سازی کرده میتوان این کار را انجام داد
{
    //DataBaseContext DataBase = new DataBaseContext();
    public void Run()
    {
        Console.WriteLine("TestClass.Run()");
    }

    public void Dispose()
    {
        // DataBase.Dispose();
        Console.WriteLine("testclass dispose()");
        GC.SuppressFinalize(this);
    }

    // finalize (~)
    /// <summary>
    /// این متد برای حذف شی از فضای رم میباشد
    /// </summary>
    ~TestClass()
    {
        Console.WriteLine("->> finalize Testclass");
    }
}