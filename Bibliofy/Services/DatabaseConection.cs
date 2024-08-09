using Bibliofy.Models;
using Dapper;
using MySql.Data.MySqlClient;
namespace Bibliofy.Services;

public class DatabaseConection {

    private readonly string _connectionString;
    
    public DatabaseConection(string database)
    {
        _connectionString = $"Server=N144657;Port=3306;Database={database};Uid=root;Pwd=;";
    }

    public List<Livro> GetLivros()
{
    using (var connection = new MySqlConnection(_connectionString))
    {
        return connection.Query<Livro>("SELECT ID, TITULO, AUTOR, ISBN, Data_De_Publicacao, DISPONIBILIDADE, BIBLIOTECA_ID FROM Livros").ToList();
    }
}

}