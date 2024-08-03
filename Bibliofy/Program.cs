﻿
using Bibliofy.Models;
using Bibliofy.Services;


Livro SrAneis = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", "001", new DateOnly(1954, 7, 29), Livro.Disponibilidade.Disponivel);
Livro orwell = new Livro("1984", "George Orwell", "002", new DateOnly(1949, 6, 8), Livro.Disponibilidade.Disponivel);
Livro casmurro = new Livro("Dom Casmurro", "Machado de Assis", "003", new DateOnly(1899, 1, 1), Livro.Disponibilidade.Disponivel);
Usuario davi = new Usuario(1, "Davi", 22);
Usuario joao = new Usuario(2, "Joao", 23);
Usuario luiz = new Usuario(3, "Luiz", 30);
Biblioteca biblioteca1 = new Biblioteca("Biblioteca Central", "Rua Principal, 123");
Biblioteca biblioteca2 = new Biblioteca("Biblioteca Comunitária", "Rua Secundária, 456");

List<Livro> livrosDaBilbioteca = biblioteca2.ObterLivrosDaBiblioteca();
List<Usuario> usuariosDaBiblioteca = biblioteca2.ObterUsuariosDaBilbioteca();
biblioteca1.AdicionarLivroABiblioteca(SrAneis);
biblioteca2.AdicionarLivroABiblioteca(orwell);
biblioteca1.AdicionarLivroABiblioteca(casmurro);
biblioteca1.AdicionarUsuarioABiblioteca(davi);
biblioteca1.AdicionarUsuarioABiblioteca(joao);
biblioteca2.AdicionarUsuarioABiblioteca(luiz);


foreach(Usuario usuario in usuariosDaBiblioteca)
{
    Console.WriteLine($"{usuario.NomeUsu} - {usuario.Idade}");
    
}

foreach(Livro livro in livrosDaBilbioteca)
{
    Console.WriteLine($"{livro.Titulo} - {livro.DataPublicacao} - {livro.Autor} - {livro.ISBN}");
    
}

