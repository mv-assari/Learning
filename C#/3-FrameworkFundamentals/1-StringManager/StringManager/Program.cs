using System.Globalization;

Console.WriteLine("=========Char=============");

char i = 'j';

Console.WriteLine(char.ToUpper(i)); //زبان سیستم عامل مهم است
Console.WriteLine(char.ToUpperInvariant(i));//زبان سیستم عامل مهم نیست و زبان انگلیسی مد نظر هست
Console.WriteLine(char.ToUpper(i,CultureInfo.InvariantCulture));//زبان انگلیسی مد نظر هست

Console.WriteLine(char.IsDigit(i));
Console.WriteLine(char.IsLetterOrDigit('.'));
Console.WriteLine(char.IsDigit('4'));
Console.WriteLine(char.IsNumber('5'));
Console.WriteLine(char.IsWhiteSpace(' '));


Console.WriteLine(char.GetUnicodeCategory(i));
Console.WriteLine(char.GetNumericValue('6'));

Console.WriteLine("==========String============");

//string m = new string('*', 5);

//string name = "salalm \n azizam";

//string path = "c:\\temp\\s";
//string path = @"c:\temp\s";

string name = "";
Console.WriteLine(name=="");
Console.WriteLine(name==string.Empty);
Console.WriteLine(name.Length==0);


string lastname = null;
Console.WriteLine(lastname==null);
Console.WriteLine(string.IsNullOrEmpty(lastname));


string mva = "mva";
char v = mva[1];

foreach (char c in mva)
{
    //Console.WriteLine(c);
}


//Console.WriteLine("welcome to mva".StartsWith('w'));
//Console.WriteLine("welcome to mva".EndsWith('a'));
//Console.WriteLine("welcome to mva".Contains("mva"));


//Console.WriteLine("welcome to mva".IndexOf("mva"));
//Console.WriteLine("welcome to mva".LastIndexOf("mva"));
//Console.WriteLine("welcome to mva".IndexOfAny(new char[] {'m','t'}));
//Console.WriteLine("welcome to mva".LastIndexOfAny(new char[] {'m','t'}));




//Console.WriteLine("welcome to mva".Substring(11));
//Console.WriteLine("welcome to mva".Substring(0,10));
//Console.WriteLine("welcome to mva".Replace('w','W'));
//Console.WriteLine("welcome to mva".Replace("to","To"));
//Console.WriteLine("welcome to mva".Replace(" ","-"));
//Console.WriteLine("welcome to mva".Insert(0,"---> "));
//Console.WriteLine("welcome to mva".Remove(0,2));



string message = "welcome to mva";
string[] words=message.Split();//به صورت پیش فرض فضای خالی یا همون اسپیس رو مبنا میگرید برای جداسازی
foreach (var item in words)
{
    Console.WriteLine(item);
}

string newMessage = string.Join(' ', words);
Console.WriteLine(newMessage);

string newMessage2=string.Concat(words);
Console.WriteLine(newMessage2);



string yourname = "vahid";
byte yourage = 32;

Console.WriteLine(string.Format("name:{0} and age:{1}.",yourname,yourage));
Console.WriteLine($"name:{yourname} and age:{yourage}");






Console.ReadLine();