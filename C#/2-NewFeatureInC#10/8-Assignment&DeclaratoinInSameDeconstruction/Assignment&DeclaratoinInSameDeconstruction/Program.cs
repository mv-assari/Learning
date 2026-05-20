// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Point point = new Point(10, 20);

int x;
(x, int y) = point; //در این حالت میتوان از قبل متغیر تعریف شود و در این جا از آن استفاده شود

public record Point(int a,int b);
