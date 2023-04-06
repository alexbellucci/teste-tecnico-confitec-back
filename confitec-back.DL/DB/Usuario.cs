using confitec_back.DL.Services.DAL;
using System;

#nullable disable

namespace confitec_back.DL.DB
{
    public partial class Usuario : IEntity
    {
        public Usuario()
        {
        }

        public long Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Escolaridade { get; set; }
    }
}

