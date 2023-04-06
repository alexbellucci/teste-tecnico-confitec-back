using confitec_back.DL.Enums;
using System;

namespace confitec_back.DL.Request.Usuario
{
    public class UsuarioRequest
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public EEscolaridade Escolaridade { get; set; }
    }
}