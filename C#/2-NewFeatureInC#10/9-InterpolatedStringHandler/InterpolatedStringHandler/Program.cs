// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("Hello, World!");

var date=DateTime.Now;

// Composit Formating
Console.WriteLine("Today is {0}, it's {1:HH:mm} now.",date.DayOfWeek,date);

// String Interpolation
Console.WriteLine($"Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

User user = new User();
user.SetDescription($"this is a test at : year={date.Year} day={date.Day}");
Console.WriteLine(user.Description);


public class User
{
    public string? Description { get; private set; }
    public void SetDescription(string description)
    {
        Description = description;
    }
    public void SetDescription(InterpolatedStringHandler description)
    {
        Description = description.ToString();
    }
}


[InterpolatedStringHandler]
public ref struct InterpolatedStringHandler
{
    StringBuilder builder;

    public InterpolatedStringHandler(int literalLength, int formattedCount)
    {
        builder = new StringBuilder(literalLength);
    }

    public void AppendLiteral(string s)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\tAppendLiteral called: {{{s}}}");
        builder.Append(s);
        Console.ForegroundColor = ConsoleColor.Yellow;

    }

    public void AppendFormatted<T>(T t)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");

        if (t?.ToString()?.Length < 100)
        {
            builder.Append(t?.ToString());
        }
        Console.ForegroundColor = ConsoleColor.Yellow;

    }

    public override string ToString()
    {
        return builder.ToString();
    }

    public string GetText()
    {
        return builder.ToString();
    }
}
