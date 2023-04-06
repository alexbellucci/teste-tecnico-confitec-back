using confitec_back.DL.DB;
using confitec_back.DL.Excecoes;
using confitec_back.DL.Request.Usuario;
using confitec_back.DL.Services.BLL;
using confitec_back.DL.Services.DAL;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
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
            if (usuarioRequest.DataNascimento > DateTime.Today)
                throw new DataNacimentoException("A Data de nascimento inserida é maior que o dia atual");

            if (!IsValid(usuarioRequest.Email))
                throw new EmailInvalidoException("A Data de nascimento inserida é maior que o dia atual");

            Usuario usuarios = new Usuario
            {
                PrimeiroNome = usuarioRequest.PrimeiroNome,
                UltimoNome = usuarioRequest.UltimoNome,
                Email = usuarioRequest.Email,
                DataNascimento = usuarioRequest.DataNascimento,
                Escolaridade = usuarioRequest.Escolaridade,
            };
        
            return await _usuarioRepository.Create(usuarios);
        }

        public async Task<Usuario> BuscarUsuarioAsync(long idUsuario)
        {
            return await _usuarioRepository.GetById(idUsuario);
        }

        public async Task<Usuario> AlterarUsuario(long idUsuario, UsuarioRequest usuarioRequest)
        {
            if (usuarioRequest.DataNascimento > DateTime.Today)
                throw new DataNacimentoException("A Data de nascimento inserida é maior que o dia atual");

            if (!IsValid(usuarioRequest.Email))
                throw new EmailInvalidoException("A Data de nascimento inserida é maior que o dia atual");

            Usuario usuarios = new Usuario
            {
                PrimeiroNome = usuarioRequest.PrimeiroNome,
                UltimoNome = usuarioRequest.UltimoNome,
                Email = usuarioRequest.Email,
                DataNascimento = usuarioRequest.DataNascimento,
                Escolaridade = usuarioRequest.Escolaridade,
            };
            return await _usuarioRepository.Update(idUsuario, usuarios);
        }

        public async Task DeletarUsuarioAsync(long idUsuario)
        {
            await _usuarioRepository.Delete(idUsuario);
        }

        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
}
