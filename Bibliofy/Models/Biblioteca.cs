
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

    public void AlterarLivroreBiblioteca(Biblioteca biblioteca, Biblioteca novaBiblioteca, Livro livro)
    {
        biblioteca.LivrosAlocados.Remove(livro);
        novaBiblioteca.LivrosAlocados.Add(livro);
    }

       public void AdicionarUsuarioABiblioteca(Usuario usuario, Biblioteca biblioteca)
    {
        biblioteca.ListaUsuarios.Add(usuario);
    }

}