using Bibliofy.Models;

namespace Bibliofy.Services;

public class BibliotecaService
{
    private List<Livro> livros = new();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public List<Livro> ObterLivros()
    {
        return livros;
    }

    public void RemoverLivro(Livro livro)
    {
        livros.Remove(livro);
    }

    public bool AtualizarLivro(Livro livro, string novoIsbn,string novoTitulo, string novoAutor, DateOnly novaData, Livro.Disponibilidade novoStatus )
    {
        //if enorme, ou um case?
        if(livro != null)
        {
            if(novoIsbn == null)
            {
            novoIsbn = livro.ISBN;
            } //--------------------------------- Será que dá certo?

            livro.AtualizarDados(novoIsbn, novoTitulo, novoAutor, novaData, novoStatus);
            return true;
        }
        else
        {
            Console.WriteLine($"Desculpe! o livro não foi encontrado!");
            return false;
        }
    }
}