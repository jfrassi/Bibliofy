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

    public void RemoverLivro(string isbn)
    {
        var livro = livros.Where(l => l.ISBN.Equals(isbn)).FirstOrDefault();
        livros.Remove(livro);
    }

    public void AtualizarLivro(string isbn, Livro livroAtualizado)
    {
        var livro = livros.Where(l => l.ISBN.Equals(isbn)).FirstOrDefault();
        if(livro != null)
        {
            livro.Titulo = livroAtualizado.Titulo;
            livro.Autor = livroAtualizado.Autor;
        }
        else
        {
            Console.WriteLine($"Desculpe! o livro não foi encontrado!");
            
        }
    }
}