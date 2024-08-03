
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

    public List<Livro> ObterLivrosDaBiblioteca()
    {
        return LivrosAlocados;
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

    public List<Usuario> ObterUsuariosDaBilbioteca()
    {
        return ListaUsuarios;
    }

}