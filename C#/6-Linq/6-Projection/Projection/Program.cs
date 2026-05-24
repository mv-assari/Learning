List<Category> categories = new List<Category>
{
    new Category
    {
        Id=1,
        Name="Mobile",
        Products=new List<Product>
        {
            new Product{ Name="S5"},
            new Product{ Name="S6"},
            new Product{ Name="Iphone"},
            new Product{ Name="Lg"},
        }
    },
    new Category
    {
        Id=2,
        Name="Laptop",
        Products=new List<Product>
        {
            new Product{ Name="Asus"},
            new Product{ Name="Hp"},
            new Product{ Name="Lenovo"},
            new Product{ Name="Dell"},
        }
    }
};


var result = categories.Select(p => 
new MyDto
{
   CategoryName=p.Name,
   Products=p.Products
}).ToList();
;

var result2=categories.Select(p=>p.Products).ToList();

foreach (var prodcuts in result2)
{
    foreach (var item in prodcuts)
    {
        Console.WriteLine(item.Name);
    }
}

var result3 = categories.SelectMany(p => p.Products).ToList();

foreach (var item in result3)
{
    Console.WriteLine(item.Name);
}

Console.ReadLine();

//------------------------------------

public class MyDto
{
    public string? CategoryName { get; set; }
    public IEnumerable<Product> Products { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public IEnumerable<Product> Products { get; set; }
}


public class Product
{
    public string? Name { get; set; }
}