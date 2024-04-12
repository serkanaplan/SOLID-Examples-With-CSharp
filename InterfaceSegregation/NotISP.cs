namespace SOLID.NotISP;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public interface IProductRepository
{
    List<Product> GetList();
    Product GetById(int id);
    Product Create(Product p);
    Product Update(Product p);
    Product Delete(Product p);
}

public class ReadPRoductRepository : IProductRepository
{
    public Product Create(Product p) => throw new NotImplementedException();

    public Product Delete(Product p) => throw new NotImplementedException();

    public Product GetById(int id) => throw new NotImplementedException();

    public List<Product> GetList() => throw new NotImplementedException();

    public Product Update(Product p) => throw new NotImplementedException();
}