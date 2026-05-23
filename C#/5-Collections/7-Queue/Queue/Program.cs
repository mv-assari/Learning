using System.Collections;

Queue<int> queue=new Queue<int>();

queue.Enqueue(0);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);

int[] q = queue.ToArray();

Console.WriteLine(queue.Count);
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());

foreach (var item in queue)
{
    Console.WriteLine(item);
}


//nonGeneric

Queue ng=new Queue();
//we can use object to enqueue


Console.ReadLine();