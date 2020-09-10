using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    /*
     * Classe para criação de mensagens personalizadas.
     */ 

    public class SaldoInsuficienteException : FinancialOperationException
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
        public SaldoInsuficienteException()
        { }

        public SaldoInsuficienteException(string message)
            : base(message)
        {}

        public SaldoInsuficienteException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public SaldoInsuficienteException(double balance, double withdrawalAmount)
            : this($"Tentativa de saque do valor de {withdrawalAmount} em uma conta com saldo de {balance}")
            // : this de um construtor que pede esse argumento.
        {
            Balance = balance;
            WithdrawalAmount = withdrawalAmount;            
        }
    }
}
