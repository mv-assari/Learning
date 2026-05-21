string[] myList = { "A", "b", "D", "C", "d", "c" };

var CurrentCulture = myList.OrderBy(x=>x,StringComparer.CurrentCulture);

Console.WriteLine("CurrentCulture");
foreach(var item in CurrentCulture)
{
    Console.WriteLine(item);

}

var InvariantCulture = myList.OrderBy(x => x, StringComparer.InvariantCulture);

Console.WriteLine("InvariantCulture");
foreach (var item in InvariantCulture)
{
    Console.WriteLine(item);

}

var Ordinal = myList.OrderBy(x => x, StringComparer.Ordinal);

Console.WriteLine("Ordinal");
foreach (var item in Ordinal)
{
    Console.WriteLine(item);

}

Console.WriteLine("Mva" == "mva");
Console.WriteLine("Mva".Equals("mva",StringComparison.OrdinalIgnoreCase));


Console.WriteLine("a".CompareTo("A"));
Console.WriteLine("a".CompareTo("a"));
Console.WriteLine("A".CompareTo("a"));

Console.ReadLine();