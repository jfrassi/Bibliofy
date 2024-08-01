namespace Bibliofy.Services;
using Bibliofy.Models;


public class BibliotecaService
{
    public void AdicionarLivroABiblioteca(Livro livro, Biblioteca biblioteca)
    {
        biblioteca.LivrosAlocados.Add(livro);
    }

    public List<Livro> ObterLivrosDaBiblioteca(Biblioteca biblioteca)
    {
        return biblioteca.LivrosAlocados;
    }

    public void RemoverLivroDaBiblioteca(Livro livro, Biblioteca biblioteca)
    {
        biblioteca.LivrosAlocados.Remove(livro);
    }

    public void AlterarBiblioteca(Biblioteca biblioteca, Biblioteca novaBiblioteca, Livro livro)
    {
        biblioteca.LivrosAlocados.Remove(livro);
        novaBiblioteca.LivrosAlocados.Add(livro);
    }

    // public bool AtualizarLivro(DateOnly novaData, Livro.Disponibilidade novoStatus Livro livro = null, string novoIsbn = null ,string novoTitulo = null, string novoAutor = null, )
    // {
    //     if(livro != null)
    //     {
            
    //         livro.AtualizarDados(novoIsbn, novoTitulo, novoAutor, novaData, novoStatus);
    //         return true;
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Desculpe! o livro não foi encontrado!");
    //         return false;
    //     }
    // }
}