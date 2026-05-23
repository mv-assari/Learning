using System.Collections;

List<string> prodcut=new List<string>(20);

prodcut.Add("a");
prodcut.AddRange(new[] { "dd", "ddd" });
prodcut.Insert(2, "f");
prodcut.InsertRange(4, new[] { "a", "b" });
prodcut.Remove("a");
prodcut.RemoveRange(2, 1);
prodcut.RemoveAll(x=>x.Equals("a"));

Console.WriteLine(prodcut[1]);
Console.WriteLine(prodcut[prodcut.Count-1]);
prodcut.Add("a");
prodcut.Add("a");
prodcut.Add("a");
prodcut.Add("a");
var list = prodcut.GetRange(3, 3);
var a= prodcut.ToArray();


ArrayList arrayList= new ArrayList();
arrayList.Add("a");
arrayList.Add(2);
arrayList.Add(new Program());

List<int> list2 = arrayList.Cast<int>().ToList();
;