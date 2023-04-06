using System;

namespace confitec_back.DL.Excecoes
{
    [Serializable]
    public class DataNacimentoException : Exception
    {
        public DataNacimentoException() : base() { }
        public DataNacimentoException(string message) : base(message) { }
    }
}