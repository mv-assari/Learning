string[] names = {"vahid","arash","mahdi","yaser" };

var query = from c in names
            where c.Length >= 3
            where c.Contains('a')
            orderby c.Length
          select c.ToUpper();

foreach (var item in query)
{
    Console.WriteLine(item);
}


 var method=names.Where(c=>c.Length >= 3)
                 .Where(c=>c.Contains('a'))
                 .OrderBy(c=>c.Length)
                 .Select(c=>c.ToUpper());

foreach (var item in method)
{
    Console.WriteLine(item);
}

Console.ReadLine();