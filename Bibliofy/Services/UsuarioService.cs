namespace Bibliofy.Services;

using Bibliofy.Models;

public class UsuarioService
{
    List<Usuario> usuarios = new();

    public List<Usuario> ObterUsuarios()
    {
        return usuarios;
    }


    public bool AlterarUsuario(Usuario usuario, int novoCodigo, string novoNome, int novaIdade)
    {
        if (usuario != null)
        {
            usuario.AtualizarDadosUsuario(novoCodigo, novoNome, novaIdade);
            return true;
        }

        return false;
    }

}