IDictionary<int,string> dic = new Dictionary<int,string>();

dic.Add(1, "a");
dic.Add(2, "b");
dic.Add(3, "c");
dic.Add(4, "d");
dic.Add(5, "e");
dic.TryAdd(5, "f");

dic.Remove(3);
dic.Clear();
dic.TryGetValue(2, out string s);
dic.ContainsKey(2);

var tryget = dic.TryGetValue(2, out s);



Console.WriteLine(s);