namespace SOLID.NotDIP;

public class ProductService(ProductRepositoryFromSqlServer repository)
{
    private readonly ProductRepositoryFromSqlServer _repository = repository;
    public List<string> GetAll() => _repository.GetAll();
}


public class ProductRepositoryFromSqlServer
{
    public List<string> GetAll() => ["SqlServer Kalem 1", "SqlServerKalem 2"];
}
