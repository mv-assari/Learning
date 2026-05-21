using System.Globalization;

DateTime dt =new DateTime(1405,02,31,new PersianCalendar());
DateTimeOffset dtOffset = DateTimeOffset.Now;
Console.WriteLine(dt);
Console.WriteLine(dtOffset);

dt.AddDays(1);
dt.AddYears(1);
dt.AddMonths(1);
dt.AddSeconds(1);
dt.AddMinutes(1);
dt.AddHours(1);


//DateTime and DateTimeOffset 
//خصوصیات مشترکی دارند

Console.ReadLine();