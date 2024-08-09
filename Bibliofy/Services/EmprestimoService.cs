namespace Bibliofy.Services;

using Bibliofy.Models;

public class EmprestimoService
{
    public void EmprestarLivro(Livro livro, Usuario usuario)
    {
        if (livro.Status == Livro.Disponibilidade.Disponivel)
        {
            usuario.LivrosEmprestados.Add(livro);
            livro.AlterarStatus(Livro.Disponibilidade.Emprestado);
            Emprestimo emprestimo = new Emprestimo
            (
                livro,
                usuario,
                new DateOnly(),
                new DateOnly().AddDays(7)
            );
        }
        else
        {
            Console.WriteLine($"Desculpe, o livro {livro} não está disponível");
        }
    }

    public void DevolverLivro(Livro livro, Usuario usuario)
    {
        if (livro.Status == Livro.Disponibilidade.Emprestado)
        {
            usuario.LivrosEmprestados.Remove(livro);
            livro.AlterarStatus(Livro.Disponibilidade.Disponivel);
        }
    }

    public void ObterEmprestimos(Usuario usuario)
    {
        var emprestados = usuario.LivrosEmprestados.Select(p => new
        {
            titulo = p.Titulo,
            isbn = p.ISBN,
            autor = p.Autor,
            dataPublicacao = p.DataDePublicacao,
            status = p.Status
        }).ToList();
        foreach (var livro in emprestados)
        {
            Console.WriteLine($"{livro.titulo} - {livro.autor} - {livro.dataPublicacao} - {livro.dataPublicacao} - {livro.status} - {livro.isbn}");
        }
    }
}