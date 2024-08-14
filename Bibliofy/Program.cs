
using System.Runtime.CompilerServices;
using Bibliofy.Models;
using Bibliofy.Repositories;
using Bibliofy.Services;


LivroRespository LivroBD = new("bibliofy");

UsuarioRepository UsuarioBD = new("bibliofy");

Usuario joao = new Usuario("João Victor Frassi", 23);



// UsuarioBD.ObterUsuários();
UsuarioBD.ExcluirUsuario(7);
// UsuarioBD.ObterUsuários();



