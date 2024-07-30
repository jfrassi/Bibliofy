
namespace Bibliofy.Models;
internal class Biblioteca
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