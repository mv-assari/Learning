TimeSpan t1 = new TimeSpan(2, 2, 14, 49, 1);
Console.WriteLine(t1.Days);

var t2 = TimeSpan.FromMinutes(-5);
var t3 = DateTime.Now.TimeOfDay;
Console.WriteLine(t2);
Console.WriteLine(t3.Minutes);

var t4 = t3 - t2;

Console.ReadLine();