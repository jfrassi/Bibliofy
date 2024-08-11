using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dapper;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Bibliofy.Models;

public class Livro
{
    public List<Livro> ListaLivros = new();
    [Key]
    public int ID { get; protected set; }
    [Column("TITULO")]
    public string Titulo { get; protected set; }
    [Column("AUTOR")]
    public string Autor { get; protected set; }
    [Column("ISBN")]
    public string ISBN { get; protected set; }
    [Column("DATA_DE_PUBLICACAO")]
    public DateTime DataDePublicacao { get; protected set; }
    [Column("DISPONIBILIDADE")]
    public Disponibilidade Status { get; protected set; }
    [ForeignKey("BIBLIOTECA")]
    public int Biblioteca_Id { get; protected set; }

    [NotMapped]
    public string DisponibilidadeString => Status.ToString();
    public enum Disponibilidade
    {
        Disponivel,
        Emprestado,
        Reservado
    }

    public Livro() { }

    public Livro
    (
        int id,
        string titulo,
        string autor,
        string isbn,
        DateTime dataPublicacao,
        Disponibilidade status,
        int biblioteca_id
    )
    {
        SetID(id);
        SetTitulo(titulo);
        SetAutor(autor);
        SetISBN(isbn);
        SetDataDePublicacao(dataPublicacao);
        SetDisponibilidade(status);
        SetBibliotecaID(biblioteca_id);
    }

    private void SetID(int id)
    {
        ID = id;
    }
    public void SetTitulo(string titulo)
    {
        Titulo = titulo;
    }
    public void SetAutor(string autor)
    {
        Autor = autor;
    }
    public void SetISBN(string isbn)
    {
        ISBN = isbn;
    }
    public void SetDataDePublicacao(DateTime data)
    {
        DataDePublicacao = data;
    }
    public void SetDisponibilidade(Disponibilidade status)
    {
        Status = status;
    }
    
    public void SetBibliotecaID(int bibliotecaID)
    {
        Biblioteca_Id = bibliotecaID;
    }

    public void AtualizarDados(
        int id,
        string novoIsbn,
        string novoTitulo,
        string novoAutor,
        DateTime? novaData,
        Disponibilidade? novoStatus,
        int bibliotecaID
       )
    {
        ID = id;
        Titulo = novoTitulo;
        Autor = novoAutor;
        ISBN = novoIsbn;
        DataDePublicacao = novaData.Value;
        Status = novoStatus.Value;
        Biblioteca_Id = bibliotecaID;

    }
    public void AlterarStatus(Disponibilidade novoStatus)
    {
        Status = novoStatus;
    }
}