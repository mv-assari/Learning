// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public struct Address
{
    public Address(string city)
    {
        City = city;
    }

    public string City { get; set; } = "UnKnown";
    public string State { get; set; }="UnKnown";
    public string PhoneNumber { get; set; } = "UnKnown";
}
