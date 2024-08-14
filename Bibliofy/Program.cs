
using System.Runtime.CompilerServices;
using Bibliofy.Models;
using Bibliofy.Repositories;
using Bibliofy.Services;


LivroRespository LivroBD = new("bibliofy");
UsuarioRepository UsuarioBD = new("bibliofy");
BibliotecaRepository BibliotecaBD = new("bibliofy");

// BibliotecaBD.ObterBibliotecas();
Biblioteca saraiva = new("Saraiva", "Avenidade 1111");
BibliotecaBD.InserirBiblioteca(saraiva);





