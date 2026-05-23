//public interface IEnumerator
//{
//    bool NextValue();
//    object Current {  get; }
//    void Reset();
//}

//public interface IEnumerable
//{
//    IEnumerator GetEnumerator();
//}


using System.Collections;

string str = "mva.com";

IEnumerator enumerator=str.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

foreach (var item in str)
{
    Console.WriteLine(item);
}

Console.ReadLine();
