using confitec_back.DL.DB;
using confitec_back.DL.Request.Usuario;
using System.Threading.Tasks;

namespace confitec_back.DL.Services.BLL
{
    public interface IUsuarioService
    {
        Task<Usuario> CriarUsuario(UsuarioRequest usuarioRequest);

        Task<Usuario> BuscarUsuarioAsync(long idUsuario);

        Task<Usuario> AlterarUsuario(long idUsuario, UsuarioRequest usuarioRequest);

        Task DeletarUsuarioAsync(long idUsuario);
    }
}