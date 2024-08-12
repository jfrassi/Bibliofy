
using System.Runtime.CompilerServices;
using Bibliofy.Models;
using Bibliofy.Repositories;
using Bibliofy.Services;


LivroRespository LivroBD = new("bibliofy");


LivroBD.AtualizarDadosLivro(3, "Testando legal", "João Victor");





