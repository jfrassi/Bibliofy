namespace Bibliofy.Repositories;

using Bibliofy.Models;
using Dapper;
using MySql.Data.MySqlClient;

public class LivroRespository
{

    private readonly string _connectionString;

    public LivroRespository(string database)
    {
        _connectionString = $"Server=N144657;Port=3306;Database={database};Uid=root;Pwd=;";
    }

    public void ObterLivros()
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            var listaDeLivros = connection.Query<Livro>("SELECT * FROM LIVROS").ToList();
            foreach (var livro in listaDeLivros)
            {
                Console.WriteLine($"{livro.Titulo} - {livro.Autor}");

            }
            Console.WriteLine($"--------> Acabou aqui <-------");

        }
    }

    public void InserirLivro(Livro livro)
    {

        using (var connection = new MySqlConnection(_connectionString))
        {
            try
            {
                var insert = "INSERT INTO LIVROS (ID, TITULO, AUTOR, ISBN, DATA_DE_PUBLICACAO, DISPONIBILIDADE, BIBLIOTECA_ID) values (@ID, @TITULO, @AUTOR, @ISBN, @DATADEPUBLICACAO, @DISPONIBILIDADESTRING, @BIBLIOTECA_ID)";
                connection.Execute(insert, livro);
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                Console.WriteLine($"Um livro com esse id já existe!");

            }
        }
    }

    public void ExcluirLivro(int livroId)
    {
        using (var connection = new MySqlConnection(_connectionString))
            try
            {
                var livroExistente = connection.QueryFirstOrDefault<Livro>("SELECT * FROM LIVROS WHERE ID  = @ID;", new
                {
                    ID = livroId
                });
                if (livroExistente != null)
                {
                    var delete = "DELETE FROM LIVROS WHERE ID = @ID";
                    connection.Execute(delete, new { ID = livroId });
                    Console.WriteLine($"Livro excluído com sucesso!");

                }
                else
                {
                    Console.WriteLine($"Desculpe esse livro não existe");
                    
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro {ex.Message}");
                
            }
    }
}