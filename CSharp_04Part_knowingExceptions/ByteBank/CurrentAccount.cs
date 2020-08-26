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



        /*--------------------
         * Métodos
         *------------------*/
        public CurrentAccount(int agencia, int numero)
        {

            if (agencia <= 0)
            {
                throw new ArgumentException("A agencia deve ser maior que 0.");
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número deve ser maior que 0.");
            }

            // || -> pipe --------------------------- Salvar

            Agencia = agencia;
            _numero = numero;

            //OperationRate = 30 / AccountCreatedTotal;

            AccountCreatedTotal++;
        }


        public bool Sacar(double valor)
        {            
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, CurrentAccount contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
