using Bibliofy.Services;

namespace Bibliofy.Models;

internal class Emprestimo
{
    public Livro Livro { get; protected set; }
    public Usuario Usuario { get; protected set; }
    public DateOnly DataEmprestimo { get; protected set; }
    public DateOnly DataDevolucao { get; protected set; }

    public Emprestimo
    (
        Livro livro,
        Usuario usuario,
        DateOnly dataEmprestimo,
        DateOnly dataDevolucao
    )
    {
        SetLivro(livro);
        SetUsuario(usuario);
        SetDataEmprestimo(dataEmprestimo);
        SetDataDevolucao(dataDevolucao);
    }

    public void SetLivro(Livro livro)
    {
        Livro = livro;
    }
    public void SetUsuario(Usuario usuario)
    {
        Usuario = usuario;
    }
    public void SetDataEmprestimo(DateOnly dataEmprestimo)
    {
        DataEmprestimo = dataEmprestimo;
    }
    public void SetDataDevolucao(DateOnly? dataDevolucao = null)
    {
        DataDevolucao = (DateOnly)dataDevolucao;
    }

    public static implicit operator Emprestimo(EmprestimoService v)
    {
        throw new NotImplementedException();
    }
}