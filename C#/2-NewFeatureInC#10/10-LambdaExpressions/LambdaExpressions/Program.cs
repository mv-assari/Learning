// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Func<string,int> ParseToInt=(string s) => int.Parse(s);
var ParseToInt=(string s) => int.Parse(s);//در سی شارپ10 این امکان وجود دارد که به صورت خودکار نوع تشخیص داده میشه

var a= ParseToInt("2");

var PrintProfile = (string name, string lastname) => Console.WriteLine($"name is:{name} lastname is:{lastname}");

PrintProfile("vahid", "assari");
//--------------------
//method groups

var Input = Console.ReadLine;
var name = Input;

var output = (string s) => Console.WriteLine(s);
output($"name is :{name}");

//---------------
//return types

var pars = object (string s) =>
{
	if (int.TryParse(s,out var value))
	{
		return value;
	}
	else
	{
		return "UnKnwon";
	}
};

Console.ReadLine();

