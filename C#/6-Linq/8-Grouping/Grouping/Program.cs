List<string> files = new List<string>()
{
    "a.exe",
    "b.exe",
    "c.pdf",
    "d.pdf",
    "e.pdf",
    "f.config",
    "g.dll",
    "h.dll",
    "i.docx",
};


var resutl2=files.ToLookup(f=>Path.GetExtension(f));//imediate


var resutl=files.GroupBy(f=>Path.GetExtension(f));//defferd

foreach(var file in resutl)
{
    Console.WriteLine($"File Extention:{file.Key}");
    foreach (var item in file)
    {
        Console.WriteLine($"      -{item}");
    }
}

Console.ReadLine();