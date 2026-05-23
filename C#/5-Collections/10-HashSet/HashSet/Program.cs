HashSet<int> hs = new HashSet<int>();

hs.Add(0);
hs.Add(1);
hs.Add(2);
hs.Add(3);
hs.Add(4);
hs.Add(5);

foreach (var item in hs)
{
    Console.WriteLine(item);
}

hs.Remove(0);
hs.RemoveWhere(x=>x>2);
hs.Clear();



Console.ReadLine();
