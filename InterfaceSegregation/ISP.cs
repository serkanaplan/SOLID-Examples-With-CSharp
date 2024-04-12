namespace SOLID.LSP;

public class ReadPRoductRepository : IReadRepository
{
    public Product GetById(int id) => throw new NotImplementedException();
    public List<Product> GetList() => throw new NotImplementedException();
}

public class WritePoductRepository : IWriteRepository
{
    public Product Create(Product p) => throw new NotImplementedException();

    public Product Delete(Product p) => throw new NotImplementedException();

    public Product Update(Product p) => throw new NotImplementedException();
}


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public interface IReadRepository
{
    List<Product> GetList();
    Product GetById(int id);
}

public interface IWriteRepository
{
    Product Create(Product p);
    Product Update(Product p);
    Product Delete(Product p);
}
