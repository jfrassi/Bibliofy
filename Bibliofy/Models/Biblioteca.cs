
namespace Bibliofy.Models;
public class Biblioteca
{
    public string Nome { get; protected set; }
    public string Endereco { get; protected set; }
    List<Livro> LivrosAlocados = new();
    List<Usuario> ListaUsuarios = new();

    public Biblioteca
    (
        string nome,
        string endereco
    )
    {
        SetNomeBiblioteca(nome);
        SetEndereco(endereco);
    }

    public void SetNomeBiblioteca(string nome)
    {
        Nome = nome;
    }
    public void SetEndereco(string endereco)
    {
        Endereco = endereco;
    }


    public void AdicionarLivroABiblioteca(Livro livro)
    {
        LivrosAlocados.Add(livro);
    }

    public void ObterLivrosDaBiblioteca()
    {
        var livros = LivrosAlocados.Select(p => new
        {
            titulo = p.Titulo,
            isbn = p.ISBN,
            autor = p.Autor,
            dataPublicacao = p.DataPublicacao,
            status = p.Status
        }).ToList();

        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.titulo} - {livro.autor} - {livro.dataPublicacao} - {livro.dataPublicacao} - {livro.status} - {livro.isbn}");

        }
    }

    public void RemoverLivroDaBiblioteca(Livro livro)
    {
        LivrosAlocados.Remove(livro);
    }

    public void AlterarLivroDeBiblioteca(Biblioteca biblioteca, Biblioteca novaBiblioteca, Livro livro)
    {
        biblioteca.LivrosAlocados.Remove(livro);
        novaBiblioteca.LivrosAlocados.Add(livro);
    }

    public void AdicionarUsuarioABiblioteca(Usuario usuario)
    {
        ListaUsuarios.Add(usuario);
    }

    public void RemoverUsuarioDaBibioteca(Usuario usuario)
    {
        ListaUsuarios.Remove(usuario);
    }

    public void ObterUsuariosDaBilbioteca()
    {
        var usuarios = ListaUsuarios.Select(p => new
        {
            idade = p.Idade,
            nome = p.NomeUsu,
            codigo = p.Codigo
        }).ToList();
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"{usuario.codigo} - {usuario.nome} - {usuario.idade} anos");

        }
    }

}