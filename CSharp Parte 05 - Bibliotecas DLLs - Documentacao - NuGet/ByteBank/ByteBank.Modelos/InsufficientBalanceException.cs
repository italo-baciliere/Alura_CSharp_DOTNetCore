using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class InsufficientBalanceException : FinancialOperationException
    /*
     * Utilizamos o sufixo <Exception> para facilitar o entendimento que é uma exceção
     * Toda excecão  deve derivar do tipo Exception
     * 
     * Exception é a classe pai/base de todas as
     * exceções no C# e no .NET
    */
    {

        /*--------------
         * Variables
         *--------------
         */
        public double Balance { get; }
        public double WithdrawalAmount { get; }



        /*
         * Constructor
         */
        public InsufficientBalanceException()
        { }

        public InsufficientBalanceException(string message)
            : base(message)
        { }

        public InsufficientBalanceException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public InsufficientBalanceException(double balance, double withdrawalAmount)
            : this($"Tentativa de saque do valor de {withdrawalAmount} em uma conta com saldo de {balance}")
        // : this de um construtor que pede esse argumento.
        {
            Balance = balance;
            WithdrawalAmount = withdrawalAmount;
        }
    }
}
