using System.Collections.Immutable;

//ImmutableArray<T>;
//ImmutableList<T>;
//ImmutableDictionary<K,V>;
//ImmutableHashSet<T>;
//ImmutableSortedDictionary<K, V>;
//ImmutableSortedSet<T>;
//ImmutableQueue<T>;
//ImmutableStack<T>;

ImmutableList<int> mylist = ImmutableList.Create<int>(1,2,3,4);

var newmylist= mylist.Add(5);

//mylist.AddRange(newmylist);
//mylist.RemoveRange(newmylist);

//ImmutableList<int>.Builder listbuilder=ImmutableList.CreateBuilder<int>();


ImmutableArray<int>.Builder builder= ImmutableArray.CreateBuilder<int>();

builder.Add(1);
builder.Add(2);
builder.Add(3);
builder.Add(4);
builder.Add(5);

var arraybuilder=builder.ToImmutable();

foreach (var item in mylist)
{
    Console.WriteLine(item);
}

foreach (var item in newmylist)
{
    Console.WriteLine(item);
}

Console.ReadLine();