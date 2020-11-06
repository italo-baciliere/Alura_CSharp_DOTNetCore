using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class FinancialOperationException : Exception
    {
        public FinancialOperationException()
        {
        }

        public FinancialOperationException(string message)
            : base(message)
        {
        }

        public FinancialOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
