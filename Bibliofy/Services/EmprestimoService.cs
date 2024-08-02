namespace Bibliofy.Services;

using Bibliofy.Models;

public class EmprestimoService
{
    public void EmprestarLivro(Livro livro, Usuario usuario)
    {
        if(livro.Status == Livro.Disponibilidade.Disponivel)
        {
            usuario.LivrosEmprestados.Add(livro);
            livro.AlterarStatus(Livro.Disponibilidade.Emprestado);
        }
        else 
        {
            Console.WriteLine($"Desculpe, o livro {livro} não está disponível");
        }
    }

    public void DevolverLivro(string parameter)
    {
        
    }

    public void ObterEmprestimos(string parameter)
    {
        
    }
}