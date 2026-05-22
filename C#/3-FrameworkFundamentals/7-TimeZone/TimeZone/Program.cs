TimeZone timeZone =TimeZone.CurrentTimeZone;//این نسخه منسوخ شده است 
Console.WriteLine(timeZone.StandardName);
Console.WriteLine(timeZone.DaylightName);

TimeZoneInfo zoneInfo = TimeZoneInfo.Local;//این نسخه مورد استفاده قرار میگیره و قابلیت بیشتری هم دارد
Console.WriteLine(zoneInfo.StandardName);
Console.WriteLine(zoneInfo.DaylightName);

DateTime time1 = new DateTime(2024,04,10);
DateTime time2 = new DateTime(2024,01,10);

Console.WriteLine(zoneInfo.IsDaylightSavingTime(time1));
Console.WriteLine(zoneInfo.IsDaylightSavingTime(time2));
Console.WriteLine(zoneInfo.GetUtcOffset(time1));




Console.ReadLine();