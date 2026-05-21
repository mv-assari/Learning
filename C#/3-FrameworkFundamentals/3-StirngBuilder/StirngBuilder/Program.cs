using System.Diagnostics;
using System.Text;

Stopwatch stopwatch = Stopwatch.StartNew();
stopwatch.Start();

string result = "hi ,";
result += "welcome to mva";

for (int i = 0; i < 50000; i++)
{
    result += i;
}

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);

stopwatch.Reset();
StringBuilder stringBuilder = new StringBuilder("hi ,");
stringBuilder.Append("welcome to mva");

for (int i = 0; i < 50000; i++)
{
    stringBuilder.Append(i);
}
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);



Console.ReadLine();