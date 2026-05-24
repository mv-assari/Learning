
product product = new product();
product.SetId(10).SetName("shelang").SetPrice(120000).Print();




Console.ReadLine();
public class product
{
    private int Id {  get; set; }
    private string Name { get; set; }
    private decimal Price { get; set; }

    public product SetId(int id)
    {
        Id = id;
        return this;
    }

    public product SetName(string name)
    {
        Name = name;
        return this;
    }

    public product SetPrice(decimal price)
    {
        Price = price; 
        return this;
    }

    public void Print()
    {
        Console.WriteLine($"Id:{Id} Name:{Name} Price:{Price}");
    }
}