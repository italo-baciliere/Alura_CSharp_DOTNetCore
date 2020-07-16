using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
//using _05_ByteBank; //Não é preciso importar o namespace porque esse arquivo ja faz parte dele

namespace _06_ByteBank
{
    class ContaCorrente
    {
        // Alterar todos os campos para private, pois a alteração será feita pelos métodos get e set.
        // Os métodos de Get e Set desse campo formam o que chamamos de encapsulamento.
        // Por convenção insire um _ antes dos campos.
        
        /* private Cliente titular;
        private int _numeroAgencia;
        private int _numero;
        private double _saldo; */

        public Cliente Titular { get; set; }
        public int NumeroAgencia { get; set; }
        public int Numero { get; set; }

        private double _saldo;

        public double Saldo // Por convenção o nome desse método se inicia com maiúscula.
        {
            get
            {
                return this._saldo; // Poderia ser apenas saldo, pois não existe nem um argumento com esse mesmo nome
            }
            set
            {
                if (value < 0)
                {
                    return; // Return em um método com void, ele para a execução do bloco.                
                }
                else
                {
                    this._saldo = value;
                }
                // Palavra reservada que funciona apenas nesse contexto: <value>.
            }
        }



        /*-----------------------------
        |   Função para subtrair um valor da conta da instância
        |------------------------------
        */
        public bool Sacar(double value)  // Utilzar sempre nomes no infinitivo
        {
            if (this._saldo <= value) // this -> palavra reservada. O this acessa o saldo desta instancia
            {
                return false;
            }
            else
            {
                this._saldo -= value;
                return true;
            }
        }


        /*-----------------------------
        |   Função para incrementar um valor da conta da instância
        |------------------------------
        |
        |   Retorna o valor atual do saldo,
        | apenas para facilitar a exibição ao
        | usuário.
        */
        public double Depositar(double value)
        {
            this._saldo += value;

            return this._saldo;
        }


        /*-----------------------------
        |   Função para transferir um valor da conta da instância
        |------------------------------
        |
        |   Retorna o valor atual do saldo,
        | apenas para facilitar a exibição ao
        | usuário.
        */
        public bool Transferir(double value, ContaCorrente contaDestino)
        {

            if (this._saldo < -100)
            {
                return false;
            }
            else
            {
                this._saldo -= value;
                contaDestino.Depositar(value);

                return true;
            }
        }
    }
}
