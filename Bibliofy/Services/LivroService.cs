namespace Bibliofy.Services;

using Bibliofy.Models;

public class LivroService
{
    List<Livro> listaLivros = new();
    public void AdicionarLivro(Livro livro)
    {
        listaLivros.Add(livro);
    }
}