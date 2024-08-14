namespace Bibliofy.Repositories;

using System.Text;
using Bibliofy.Models;
using Dapper;
using MySql.Data.MySqlClient;

public class UsuarioRepository
{
    private readonly string _connectionString;


    public UsuarioRepository(string database)
    {
         _connectionString = $"Server=N144657;Port=3306;Database={database};Uid=root;Pwd=;";
    }
    
    public void ObterUsuários()
    {
        using(var connection = new MySqlConnection(_connectionString))
        {
            var listaDeUsuarios = connection.Query<Usuario>("SELECT ID, NOME_USUARIO, IDADE FROM USUARIOS").ToList();
            foreach(var usuario in listaDeUsuarios)
            {
                Console.WriteLine($"{usuario.ID} - {usuario.Nome_usuario} - {usuario.Idade}");
            }
        }
    }

    public void InserirUsuario(Usuario usuario)
    {
        using(var connection = new MySqlConnection(_connectionString))
        {
            try
            {
                var insert = "INSERT INTO USUARIOS(NOME_USUARIO, IDADE) VALUES (@NOME_USUARIO, @IDADE)";
                connection.Execute(insert, usuario);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Mensagem {ex.Message}");
                
            }
        }
    }

    public void RemoverUsuario(int id)
    {
        using(var connection = new MySqlConnection(_connectionString))
        {
            var parametros = new {ID = id};
            try
            {
                Usuario usuarioExistente = connection.QueryFirstOrDefault<Usuario>("SELECT ID FROM USUARIOS WHERE ID = @ID", parametros);
                if(usuarioExistente != null)
                {
                    var delete = "DELETE FROM USUARIOS WHERE ID = @ID";
                    connection.Execute(delete, parametros);
                    Console.WriteLine($"Usuario Excluido com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Desculpe essa pessoa não está cadastrada no nosso sistema!");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"{ex.Message}");
                
            }
        }
    }

    public void AtualizarDadosUsuario(int id, string? nomeUsuario = null, int? novaIdade = null)
    {
        using(var connection = new MySqlConnection(_connectionString))
        {
            var parametros = new DynamicParameters();
            var usuarioExistente = connection.QueryFirstOrDefault<Usuario>("SELECT ID FROM USUARIOS WHERE ID = @ID", new {ID = id});
            var sql = new StringBuilder("UPDATE USUARIOS SET ");
            if(usuarioExistente != null)
            {
                bool isFirst = true;
                if(nomeUsuario != null)
                {
                    if(!isFirst) sql.Append(", ");
                    sql.Append("Nome_usuario = @NOME_USUARIO");
                    parametros.Add("Nome_Usuario", nomeUsuario);
                    isFirst = false;
                }
                if(novaIdade != null)
                {
                    if(!isFirst) sql.Append(", ");
                    sql.Append("IDADE = @IDADE");
                    parametros.Add("IDADE", novaIdade);
                    isFirst = false;
                }
                sql.Append(" WHERE ID = @ID");
                parametros.Add("ID", id);
                connection.Execute(sql.ToString(), parametros);

            }
        }
    }
}