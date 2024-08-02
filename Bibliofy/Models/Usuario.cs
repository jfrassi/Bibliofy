namespace Bibliofy.Models;
public class Usuario
{
    public int Codigo { get; protected set; }
    public string NomeUsu { get; protected set; }
    public int Idade { get; protected set; }
    public List<Livro> LivrosEmprestados = new List<Livro>();

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


    public void AtualizarDadosUsuario
    (
        int novoCodigo,
        string novoNome,
        int novaIdade
    )
    {
        Codigo = novoCodigo;
        NomeUsu = novoNome;
        Idade = novaIdade;
    }
}