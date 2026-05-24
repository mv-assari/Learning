
var result=Product.GetAllProdcut().DefaultIfEmpty(new Product
{
    Id=1,
    Name="p1",
    Price=10000
});


var collection = Enumerable.Empty<string>();

var range = Enumerable.Range(10, 10);

var repeat=Enumerable.Repeat(100, 5);


//-----------------------------------

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public static List<Product> GetAllProdcut()
    {
        return new List<Product>();
    }
}