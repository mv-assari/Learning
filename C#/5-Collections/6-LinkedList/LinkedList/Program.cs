LinkedList<int> linked=new LinkedList<int>();

linked.AddFirst(1);
linked.AddLast(2);
linked.AddBefore(linked.Last, 3);
linked.AddAfter(linked.Last, 4);

foreach (var item in linked)
{
    Console.WriteLine(item);
}

linked.Clear();
linked.RemoveFirst();
linked.RemoveLast();
linked.Remove(2);
linked.Remove(linked.First);

linked.Contains(3);
linked.Find(2);
linked.FindLast(2);

//linked.CopyTo(/*array*/,/*index*/);



Console.ReadLine();
