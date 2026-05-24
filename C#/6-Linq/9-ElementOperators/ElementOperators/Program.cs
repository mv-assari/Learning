List<String> names = new List<String>()
{
 "babak",
 "maysam",
 "mona",
 "ali",
 "ebrahim",
 "bita",
 "behnam",
 "elham",
 "behnaz"
};


//var result = names.First();
var result = names.First(p=>p.Contains('s'));
var resultordefault = names.FirstOrDefault(p=>p.Contains('s'));

//var result2 = names.Last();
var result2 = names.Last(p=>p.StartsWith('x'));
var result2ordefault = names.LastOrDefault(p => p.Contains('x'));

var single = names.Single(p => p.Contains('s'));
var singleordefault = names.SingleOrDefault(p => p.Contains('s'));

var elementat = names.ElementAt(0);
var elementatordefault = names.ElementAtOrDefault(10);

