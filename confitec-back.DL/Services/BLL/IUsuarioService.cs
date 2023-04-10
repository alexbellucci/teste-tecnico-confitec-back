using confitec_back.DL.DB;
using confitec_back.DL.Request.Usuario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace confitec_back.DL.Services.BLL
{
    public interface IUsuarioService
    {
        Task<Usuario> CriarUsuario(UsuarioRequest usuarioRequest);

        Task<Usuario> BuscarUsuarioAsync(long idUsuario);

        Task<List<Usuario>> BuscarTodosUsuariosAsync();

        Task<Usuario> AlterarUsuario(long idUsuario, UsuarioRequest usuarioRequest);

        Task DeletarUsuarioAsync(long idUsuario);
    }
}