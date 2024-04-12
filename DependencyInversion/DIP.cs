namespace SOLID.DIP;


public class ProductService(IRepository repository)
{
    private readonly IRepository _repository = repository;
    public List<string> GetAll() => _repository.GetAll();
}


public class ProductRepositoryFromSqlServer : IRepository
{
    public List<string> GetAll() => ["SqlServer Kalem 1", "SqlServerKalem 2"];
}


public class ProductRepositoryFromOracle : IRepository
{
    public List<string> GetAll() => ["Oracle Kalem 1", "Oracle Kalem 2"];
}


public interface IRepository
{
    List<string> GetAll();
}