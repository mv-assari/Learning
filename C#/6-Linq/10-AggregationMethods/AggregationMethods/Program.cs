List<Product> products = new List<Product>()
{
    new Product(){Id=1,Name="mobile1",Price=120000},
    new Product(){Id=2,Name="mobile2",Price=130000},
    new Product(){Id=3,Name="mobile3",Price=140000},
    new Product(){Id=4,Name="mobile4",Price=150000},
    new Product(){Id=5,Name="mobile5",Price=160000},
};


var count=products.Count();
var longocunt = products.LongCount();//long

var conditioncount = products.Count(p => p.Price > 1400000);

var max=products.Max(p=>p.Price);
var min=products.Min(p=>p.Price);

var sum=products.Sum(p=>p.Price);
var average=products.Average(p=>p.Price);

var aggregate1 = products.Aggregate(0, (total, product) => total + product.Price);
var aggregate2 = products.Aggregate(0, (total, product) => total * product.Price);

//-------------------------------------
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; } 
}