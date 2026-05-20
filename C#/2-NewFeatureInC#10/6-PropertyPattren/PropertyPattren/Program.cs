// See https://aka.ms/new-console-template for more information

User user = new User()
{
    Id = 1,
    Name = "Test",
    Address = new Address()
    {
        City = "qom"
    }
};


Console.WriteLine(VerifyUser(user));




Console.ReadLine();



static bool VerifyUser(User user)
{
    return user is
    {
        Id: 1,
        Name: "Test",
        Address.City: "qom",//در سی شارپ10 میتوان از آبجکت هم استفاده کرد ولی در ورژن قبلی امکان این مورد نبود
    };
}



public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
}

public class Address
{
    public int Id { get; set; }
    public string City { get; set; }
}
