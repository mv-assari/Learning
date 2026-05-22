using System.Globalization;

int number = 128;
string result=number.ToString();
int number2=int.Parse(result);


int.TryParse("aaa", out int result2);
Console.WriteLine(int.TryParse("123", out int _));//اگر فقط بخواهیم ببینیم مقدار قابل تبدیل هست یا خیر از این استفاده میکنیم
Console.WriteLine(result2);

Console.WriteLine(int.Parse("(123)",NumberStyles.AllowParentheses));

NumberFormatInfo formatInfo =new NumberFormatInfo();
formatInfo.CurrencySymbol = "(TOMAN)";
formatInfo.NumberGroupSeparator = "/";
Console.WriteLine(1250000.ToString("N0",formatInfo));

CultureInfo uk= CultureInfo.GetCultureInfo("en-GB");
Console.WriteLine(1250000.ToString("C",uk));

Console.WriteLine("---------------------------------------");

Console.WriteLine("F:"+1234.789566.ToString("F"));
Console.WriteLine("N:"+1234.789566.ToString("N0"));
Console.WriteLine("D:"+1234.ToString("D15"));
Console.WriteLine("C:"+1234.789566.ToString("C"));
Console.WriteLine("P:"+.789566.ToString("P"));
Console.WriteLine("X:"+1234.ToString("X"));

Console.WriteLine("---------------------------------------");

Console.WriteLine("date (d):"+DateTime.Now.ToString("d"));
Console.WriteLine("date (D):"+DateTime.Now.ToString("D"));
Console.WriteLine("date (t):"+DateTime.Now.ToString("t"));
Console.WriteLine("date (T):"+DateTime.Now.ToString("T"));
Console.WriteLine("date (f):"+DateTime.Now.ToString("f"));
Console.WriteLine("date (F):"+DateTime.Now.ToString("F"));
Console.WriteLine("date (g):"+DateTime.Now.ToString("g"));
Console.WriteLine("date (G):"+DateTime.Now.ToString("G"));
Console.WriteLine("date (m):"+DateTime.Now.ToString("m"));
Console.WriteLine("date (M):"+DateTime.Now.ToString("M"));
Console.WriteLine("date (y):"+DateTime.Now.ToString("y"));
Console.WriteLine("date (Y):"+DateTime.Now.ToString("Y"));
Console.WriteLine("date (u):"+DateTime.Now.ToString("u"));
Console.WriteLine("date (U):"+DateTime.Now.ToString("U"));



Console.ReadLine();