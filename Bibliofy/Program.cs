using Bibliofy.Models;
using Bibliofy.Services;


BibliotecaService BiblioService = new();
UsuarioService UsuService = new();

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

Usuario usuario1 = new Usuario
(
    1,
    "joão",
    23
);
Usuario usuario2 = new Usuario
(
    2,
    "davi",
    15
);

BiblioService.AdicionarLivro(livro1);
BiblioService.AdicionarLivro(livro2);
BiblioService.AtualizarLivro(livro1, "1111","Testando Geral", "JoaoFrassi", new DateOnly(2024, 7, 31), Livro.Disponibilidade.Disponivel);

UsuService.AdicionarUsuario(usuario1);
UsuService.AdicionarUsuario(usuario2);



// Console.WriteLine($"{livro1.Autor} - {livro1.Titulo} - {livro1.DataPublicacao}");
List<Livro> livros = BiblioService.ObterLivros();
List<Usuario> usuarios = UsuService.ObterUsuarios();

foreach(var livroUsuario in livros.Zip(usuarios))
{
    var livro = livroUsuario.First;
    var usuario = livroUsuario.Second;
    Console.WriteLine($"{livro.ISBN} - {livro.Autor} - {livro.Titulo} - {livro.DataPublicacao}"); 
    Console.WriteLine($"{usuario.Codigo} - {usuario.NomeUsu} - {usuario.Idade}"); 
}

