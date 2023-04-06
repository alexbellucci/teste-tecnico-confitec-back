using System;

namespace confitec_back.DL.Excecoes
{
    [Serializable]
    public class ObjetoJaExisteException : Exception
    {
        public ObjetoJaExisteException() : base() { }
        public ObjetoJaExisteException(string message) : base(message) { }
    }
}