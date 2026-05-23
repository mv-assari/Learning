using System.Collections;

Hashtable ht= new Hashtable();

ht.Add(1, "a");
ht.Add(2, "b");
ht.Add(3, "c");
ht.Add(4, "d");

foreach (DictionaryEntry item in ht)
{
    Console.WriteLine($"key:{item.Key} value:{item.Value}");
}
var key1 = ht[2];

ht.Remove(1);
ht.Clear();

ht.Contains(1);
ht.ContainsKey(2);
ht.ContainsValue("b");


Console.ReadLine();