string[] names = { "Parsa", "Arash", "Vahid", "Fatemeh" };

var result = names.Where(x => x.StartsWith('V')).ToList();

foreach (var name in result)
{
    Console.WriteLine(name);
}

Console.ReadLine();