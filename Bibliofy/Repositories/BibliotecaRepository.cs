namespace Bibliofy.Repositories;

using System.Text;
using Bibliofy.Models;
using Dapper;
using MySql.Data.MySqlClient;


public class BibliotecaRepository
{
    private readonly string _connectionString;

    public BibliotecaRepository(string database)
    {
        _connectionString = $"Server=N144657;Port=3306;Database={database};Uid=root;Pwd=;";
    }

    public void ObterBibliotecas()
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            var listaBibliotecas = connection.Query<Biblioteca>("SELECT ID, NOME, ENDERECO FROM BIBLIOTECA").ToList();
            foreach (var biblioteca in listaBibliotecas)
            {
                Console.WriteLine($"{biblioteca.ID} - {biblioteca.Nome} - {biblioteca.Endereco}");
            }
        }
    }

    public void InserirBiblioteca(Biblioteca biblioteca)
    {
        using(var connection = new MySqlConnection(_connectionString))
        {
            try 
            {
                var insert = "INSERT INTO BIBLIOTECA (NOME, ENDERECO) VALUES (@NOME, @ENDERECO)";
                connection.Execute(insert, biblioteca);
            }
             catch (MySqlException ex) when (ex.Number == 1062)
            {
                Console.WriteLine($"Um livro com esse id já existe!");

            }
        }
    }
}