List<Product> products = new List<Product>()
{
    new Product{Id=1,Name="p1",Price=100000},
    new Product{Id=2,Name="p2",Price=200000},
    new Product{Id=3,Name="p3",Price=300000},
    new Product{Id=4,Name="p4",Price=400000},
    new Product{Id=5,Name="p5",Price=500000},
};



bool resultall = products.All(p=>p.Price>40000);

bool resultany = products.Any(p => p.Price > 30000);

var resultcontain = products.Where(p => p.Name.Contains('p'));

bool sequenceEqual=list1.SequenceEqual(list2);

//-------------------------

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}