string[] names = { "vahid", "fatemeh", "ali", "poneh", "popak", "sima", "nima" };

var filter1=names.Where(n=>n.Contains('a')).ToList();

var filter2=names.Where((n,i)=>n.Contains('a')&& i%2==0).ToList();

var filter3 = names.Take(3).ToList();

var filter4 = names.Skip(3).ToList();

var filter5 = names.TakeWhile(n => n.Contains('a')).ToList();

var filter6= names.SkipWhile(n=>n.Contains('b')).ToList();

var filter7= names.Distinct().ToList();