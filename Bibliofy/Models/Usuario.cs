namespace Bibliofy.Models;
public class Usuario
{

    public int ID { get; protected set; }
    public string Nome_usuario { get; protected set; }
    public int Idade { get; protected set; }
    public List<Livro> LivrosEmprestados = new List<Livro>();

    public Usuario(){}
    public Usuario
    (
        string nomeUsuario,
        int idade
    )
    {
        SetNomeUsu(nomeUsuario);
        SetIdade(idade);
    }

    public void SetID(int id)
    {
        ID = id;
    }
    public void SetNomeUsu(string nome)
    {
        Nome_usuario = nome;
    }
    public void SetIdade(int idade)
    {
        Idade = idade;
    }


    public void AtualizarDadosUsuario
    (
        int novoID,
        string novoNome,
        int novaIdade
    )
    {
        ID = novoID;
        Nome_usuario = novoNome;
        Idade = novaIdade;
    }
}