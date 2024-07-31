namespace Bibliofy.Services;

using Bibliofy.Models;

public class UsuarioService 
{
    List<Usuario> usuarios = new();

    public List<Usuario> ObterUsuarios()
    {
        return usuarios;
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public void RemoverUsuario(int codigo)
    {
        var usuarioSelecionado = usuarios.Where(u => u.Codigo == codigo).FirstOrDefault();
        usuarios.Remove(usuarioSelecionado);
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