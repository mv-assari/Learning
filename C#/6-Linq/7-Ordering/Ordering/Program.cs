List<String> names = new List<String>()
{
 "babak",
 "maysam",
 "mona",
 "ali",
 "ebrahim",
 "bita",
 "behnam",
 "elham",
 "behnaz"
};

var result=names.OrderBy(n => n.Length).ThenBy(n=>n).ToList();

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------");

var result2 = result.OrderByDescending(n => n.Length).ThenByDescending(n => n).ToList();

foreach (var item in result2)
{
    Console.WriteLine(item);
}

var result3 = names.Reverse<string>(); //در اسکیوال سرور و ای اف پشتیبانی نمیشه

foreach (var item in result3)
{
    Console.WriteLine(item);
}


Console.ReadLine();