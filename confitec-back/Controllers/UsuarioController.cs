using confitec_back.DL.DB;
using confitec_back.DL.Request.Usuario;
using confitec_back.DL.Services.BLL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace confitec_back.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{usuarioId:long}")]
        public async Task<Usuario> Obter(long usuarioId)
        {
            return await _usuarioService.BuscarUsuarioAsync(usuarioId);
        }

        [HttpPost]
        public async Task<Usuario> CriarUsuarioAsync(UsuarioRequest usuarioRequest)
        {
            return await _usuarioService.CriarUsuario(usuarioRequest);
        }

        [HttpPut("{usuarioId:long}")]
        public async Task<Usuario> AtualizarUsuarioAsync(long usuarioId, UsuarioRequest usuarioRequest)
        {
            return await _usuarioService.AlterarUsuario(usuarioId, usuarioRequest);
        }

        [HttpDelete("{usuarioId:long}")]
        public async Task DeletarUsuario(long usuarioId)
        {
            await _usuarioService.DeletarUsuarioAsync(usuarioId);
        }
    }
}
