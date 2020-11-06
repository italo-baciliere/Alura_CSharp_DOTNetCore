using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ByteBank
{
    public class CurrentAccount
    {
        /*--------------------
         * Variables
         *------------------*/
        public Client Titular { get; set; }

        public static int AccountCreatedTotal { get; private set; }

        public static double OperationRate { get; private set; }                     

        private readonly int _numero; // A readonly field cannot be assigned to (except in a constructor of the class in which the field is defined or a variable initializer)
        public int Numero { get; }
        public int Agencia { get; } // Internamente o compilador cria o campo privado, somente leitura, que é devolvido no get.

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }


        /*--------------------
         * Métodos
         *------------------*/
        public CurrentAccount(int agencyNumber, int accountNumber)
        {

            if (agencyNumber <= 0)
            {
                /*----------------------------------------
                * throw -> lançando
                *----------------------------------------         
                *  Passa a exceção para adiante para alguém tratar ela.          
                */
                throw new ArgumentException("A agencia deve ser maior que 0.", nameof(agencyNumber)); // output: "agencyNumber"
                // ArgumenteException --> A exceção que é gerada quando um dos argumentos fornecidos para um método não é válido.
                // A mensagem será retornada como uma parâmetro.
                // Nome do argumento que causou a exceção --> ParamName.

                // nameof --> Uma nameof expressão produz o nome de uma variável, tipo ou membro como a constante de cadeia de caracteres
                // nameof --> retorna a variável como string
                // nmaeof --> É um operador do C#
            }

            if (accountNumber <= 0)
            {
                throw new ArgumentException("O número deve ser maior que 0.", nameof(accountNumber)); // Nome do argumento que causou a exceção --> ParamName
            }

            // || -> pipe --------------------------- Salvar

            Agencia = agencyNumber;
            _numero = accountNumber;            

            AccountCreatedTotal++;
            OperationRate = 30 / AccountCreatedTotal;
        }

        public bool Sacar(double valor)
        {
            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException($"Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                // Lançar uma exceção
                throw new SaldoInsuficienteException(_saldo, valor); // ($"Saldo insuficiente para o saque no valor de R${valor} reais.");
                // O throw new faz com que percamos a nossa antiga pilha de chamada
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, CurrentAccount contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException($"Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                /*
                 * Usando o construtur que possui a sobrecarga
                 * com uma string de mensagem e com a exceção que originou o problema                 
                 */
                throw new FinancialOperationException("Operação não realizada.", e); // INNER exceptions
            }
            
            contaDestino.Depositar(valor);            
        }
    }
}
