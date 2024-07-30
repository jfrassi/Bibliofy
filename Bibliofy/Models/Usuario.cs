namespace Bibliofy.Models;
internal class Usuario
{
    public int Codigo { get; protected set; }
    public string NomeUsu { get; protected set; }
    public int Idade { get; protected set; }
    List<Livro> LivrosEmprestados = new();

    public Usuario
    (
        int codigo,
        string nomeUsuario,
        int idade
    )
    {
        SetCodigo(codigo);
        SetNomeUsu(nomeUsuario);
        SetIdade(idade);
    }

    public void SetCodigo(int codigo)
    {
        Codigo = codigo;
    }
    public void SetNomeUsu(string nome)
    {
        NomeUsu = nome;
    }
    public void SetIdade(int idade)
    {
        Idade = idade;
    }
}