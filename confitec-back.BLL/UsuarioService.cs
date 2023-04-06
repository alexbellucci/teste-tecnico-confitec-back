using confitec_back.DL.DB;
using confitec_back.DL.Request.Usuario;
using confitec_back.DL.Services.BLL;
using confitec_back.DL.Services.DAL;
using System.Threading.Tasks;

namespace confitec_back.BLL
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> CriarUsuario(UsuarioRequest usuarioRequest)
        {
            Usuario usuarios = new Usuario
            {
                PrimeiroNome = usuarioRequest.PrimeiroNome,
                UltimoNome = usuarioRequest.UltimoNome,
            };
            
            return await _usuarioRepository.Create(usuarios);
        }

        public async Task<Usuario> BuscarUsuarioAsync(long idUsuario)
        {
            return await _usuarioRepository.GetById(idUsuario);
        }

        public async Task<Usuario> AlterarUsuario(long idUsuario, UsuarioRequest usuarioRequest)
        {
            Usuario usuarios = new Usuario
            {
                PrimeiroNome = usuarioRequest.PrimeiroNome,
                UltimoNome = usuarioRequest.UltimoNome,
            };
            return await _usuarioRepository.Update(idUsuario, usuarios);
        }

        public async Task DeletarUsuarioAsync(long idUsuario)
        {
            await _usuarioRepository.Delete(idUsuario);
        }
    }
}
