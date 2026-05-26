//GC.Collect(0);
//GC.Collect(1);
//GC.Collect(2);
using System.Runtime;

GC.Collect(1);

Console.WriteLine($"gen0:{GC.CollectionCount(0)} gen1:{GC.CollectionCount(1)} gen2:{GC.CollectionCount(2)}"); //تعداد پاکسازی که در هر سطح اتفاق افتاده است


//if is true gettotlamemory after gc
//if is false gettotalmemory before gc
temp();
Console.WriteLine(GC.GetTotalMemory(false));
Console.WriteLine(GC.GetTotalMemory(true));

while (false)
{
    temp();
    Console.WriteLine($"{GC.GetTotalAllocatedBytes()/1024/1024/1024} GB");
    Thread.Sleep(2000);
}

TempData tempData = new TempData();

GC.SuppressFinalize(tempData);//فاینالابز این آبجکت دیگه اجرا نمیشه و از صف خارج میشه
GC.ReRegisterForFinalize(tempData);//دوباره به صف برمیگردونه
GC.WaitForPendingFinalizers();//کامپایلر صبر میکنه تا تمام فاینالایزر ها اجرا بشن بعد ادامه برنامه اجرا میشه

var a = GCSettings.IsServerGC;
var b = GCSettings.LatencyMode;
GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;

void temp()
{
    byte[] data = new byte[1024 * 1024 * 1024];
}



Console.ReadLine();

public class TempData
{
}