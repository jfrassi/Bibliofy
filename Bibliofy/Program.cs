using Bibliofy.Models;
using Bibliofy.Services;


BibliotecaService servico = new();
Livro livro1 = new
    (
        "Percy Jackson",
        "Rick Riordan",
        "1234",
        new DateOnly(2001, 7, 10),
        Livro.Disponibilidade.Emprestado
    );
Livro livro2 = new
    (
        "Harry potter",
        "blablabla",
        "2134",
        new DateOnly(2007, 7, 10),
        Livro.Disponibilidade.Disponivel
    );

servico.AdicionarLivro(livro1);
servico.AdicionarLivro(livro2);
servico.RemoverLivro("2134");
servico.RemoverLivro("1234");
servico.AdicionarLivro(livro1);

// Console.WriteLine($"{livro1.Autor} - {livro1.Titulo} - {livro1.DataPublicacao}");
List<Livro> livros = servico.ObterLivros();
foreach(var livro in livros)
{
    Console.WriteLine($"{livro.Autor} - {livro.Titulo} - {livro.DataPublicacao}");
    
}

