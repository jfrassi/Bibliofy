
namespace Bibliofy.Services;

public class DatabaseConection {

    public readonly string _connectionString;
    
    public DatabaseConection(string database)
    {
        _connectionString = $"Server=N144657;Port=3306;Database={database};Uid=root;Pwd=;";
    }

}