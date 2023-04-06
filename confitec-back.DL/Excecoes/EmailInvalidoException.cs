using System;

namespace confitec_back.DL.Excecoes
{
    [Serializable]
    public class EmailInvalidoException : Exception
    {
        public EmailInvalidoException() : base() { }
        public EmailInvalidoException(string message) : base(message) { }
    }
}