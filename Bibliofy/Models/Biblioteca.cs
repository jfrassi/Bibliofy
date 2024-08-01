
namespace Bibliofy.Models;
public class Biblioteca
{
    public string Nome { get; protected set; }
    public string Endereco { get; protected set; }
    public List<Livro> LivrosAlocados = new();
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

}