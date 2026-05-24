List<int> numbers = new List<int>() { 10, 20, 30, 40 };

var query = numbers.Where(n => n > 20);
query = query.OrderByDescending(n => n);

numbers.Add(50);

foreach (var item in query)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------");
numbers.Clear();

foreach (var item in query)
{
    Console.WriteLine(item);
}



Console.ReadLine();