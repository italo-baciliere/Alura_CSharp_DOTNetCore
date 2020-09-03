using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        { }

        public SaldoInsuficienteException(string message)
            : base(message)
        {}
    }
}
