int[] myarray =new int[5];

Array array =Array.CreateInstance(typeof(int),10);


array.SetValue(125,0);
array.SetValue(120,1);
array.SetValue(155,2);

Array.Sort(array);

foreach(int i in array)
{
    Console.WriteLine(i);
}

Console.WriteLine(array.IsFixedSize);
Console.WriteLine(array.IsReadOnly);
Console.WriteLine(array.Length);
Console.WriteLine(array.LongLength);
Console.WriteLine(array.Rank);

var arrayreadonly=Array.AsReadOnly<int>(myarray);

Array.BinarySearch(array, 125);
//Array.Clear(myarray);
Array.Resize<int>(ref myarray, 20);

Array.Reverse(myarray);