using System.Diagnostics;
using System.Threading;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("test1");
Console.ResetColor();
Console.WriteLine("test2");

Console.WindowWidth = 100;//Console.LargestWindowWidth;
Console.WindowHeight = 20; //Console.LargestWindowHeight;

Console.WriteLine("------------------------------");

Console.Write("Loading  00%");
for (int i = 0; i <= 100; i++)
{
    Console.CursorLeft -= 3;
    Console.Write($"{(i).ToString("D2")}%");
    //Thread.Sleep(100);
}

//TextWriter oldText= Console.Out;

//using (TextWriter textoutput=File.CreateText("path of output text D://consoltText.txt"))
//{
//    Console.SetOut(textoutput);
//    for (int i = 0; i <= 100; i++)
//    {
//        Console.WriteLine($"line {i.ToString("D2")} {DateTime.Now.ToString("t")}");
//    }
//}

//Console.SetOut(oldText);


Console.WriteLine("----------------------------Environment------------------------");

//file and folder

Console.WriteLine(Environment.CurrentDirectory);
Console.WriteLine(Environment.SystemDirectory);
Console.WriteLine(Environment.CommandLine);

//computer and os

Console.WriteLine(Environment.MachineName);
Console.WriteLine(Environment.ProcessorCount);
Console.WriteLine(Environment.OSVersion);
Console.WriteLine(Environment.NewLine);

//user logon

Console.WriteLine(Environment.UserName);
Console.WriteLine(Environment.UserInteractive);
Console.WriteLine(Environment.UserDomainName);

//Diagnostics

Console.WriteLine(Environment.TickCount);
Console.WriteLine(Environment.StackTrace);
Console.WriteLine(Environment.WorkingSet);
Console.WriteLine(Environment.Version);


Console.WriteLine("---------------------Process-----------------------");

//Process.Start("notepad.exe");

//ProcessStartInfo startInfo = new ProcessStartInfo
//{
//    FileName = "cmd.exe",
//    Arguments = "ping 8.8.8.8"
//};

//Process process=Process.Start(startInfo);

//string result=process.StandardOutput.ReadToEnd();
//Console.WriteLine(result);


Console.WriteLine("-----------------------------AppContext----------------------------");


Console.WriteLine(AppContext.BaseDirectory);
Console.WriteLine(AppContext.TargetFrameworkName);



Console.ReadLine();