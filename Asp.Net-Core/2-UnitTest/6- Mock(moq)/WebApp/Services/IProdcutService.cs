namespace WebApp.Services
{
    public interface IBrand
    {
        public int Id { get; set; }
    }

    public interface IProdcutService
    {
        int GetProductPrice(int id);
        void GetProductPrice(int id,out int price);

        int ProductCount { get; set; }
        Product AddProduct(Product product);
        IBrand Brand { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
