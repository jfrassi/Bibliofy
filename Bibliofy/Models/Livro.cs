namespace Bibliofy.Models;

public class Livro
{
    public string Titulo { get; protected set; }
    public string Autor { get; protected set; }
    public string ISBN { get; protected set; }
    public DateOnly DataPublicacao { get; protected set; }

    public Disponibilidade Status { get; protected set; }
    public enum Disponibilidade
    {
        Disponivel,
        Emprestado,
        Reservado
    }

    public Livro
    (
       string titulo,
       string autor,
       string isbn,
       DateOnly dataPublicacao,
       Disponibilidade status
    )
    {
        SetTitulo(titulo);
        SetAutor(autor);
        SetISBN(isbn);
        SetDataDePublicacao(dataPublicacao);
        SetDisponibilidade(status);
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
    public void SetDataDePublicacao(DateOnly data)
    {
        DataPublicacao = data;
    }
    public void SetDisponibilidade(Disponibilidade status)
    {
        Status = status;
    }


    public void AtualizarDados(
        string novoIsbn,
        string novoTitulo,
        string novoAutor,
        DateOnly? novaData,
        Disponibilidade? novoStatus
       )
    {
        Titulo = novoTitulo;
        Autor = novoAutor;
        ISBN = novoIsbn;
        DataPublicacao = novaData.Value;
        Status = novoStatus.Value;

    }
}