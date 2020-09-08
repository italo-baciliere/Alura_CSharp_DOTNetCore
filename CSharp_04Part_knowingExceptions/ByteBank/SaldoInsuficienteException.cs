using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    /*
     * Classe para criação de mensagens personalizadas.
     */ 

    public class SaldoInsuficienteException : Exception
    {

        /*--------------
         * Variables
         *--------------
         */
        public double Balance { get; }
        public double WithdrawalAmount { get; }



        public SaldoInsuficienteException()
        { }
        public SaldoInsuficienteException(string message)
            : base(message)
        {}

        public SaldoInsuficienteException(double balance, double withdrawalAmount)
            : this($"Tentativa de saque do valor de {withdrawalAmount} em uma conta com saldo de {balance}")
            // : this de um construtor que pede esse argumento.
        {
            Balance = balance;
            this.WithdrawalAmount = withdrawalAmount;            
        }
    }
}
