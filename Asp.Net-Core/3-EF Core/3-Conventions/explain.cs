convention for entity class to table in database

1- public class
2- no static class


we have many property in class and should

1- public property
2- public Getter of property and Setter can public or private

we should definition class in databasecontext --> public DbSet<T>

public DbSet<Product> nameoftable {get;set;}

we have private Key in tabel and definition by --> public long Id {get;set;}
or
public class Product
{
    public long ProductId {get;set;}
}

