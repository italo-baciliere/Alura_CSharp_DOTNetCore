using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
//using _05_ByteBank; //Não é preciso importar o namespace porque esse arquivo ja faz parte dele

namespace CSharp_parte2___Introducao_a_Orientacao_a_Objetos
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
        public double Numero { get; set; }
        private double _saldo;
        private int _agencia;        
        public static int TotalDeContasCriadas { get; private set; }
        /*
        -   Ao utilizar static, dizemos que TotalDeContasCriadas é uma propriedade da classe 
        - e não dos objetos instanciados.
        - Ela é estática porque pertence a todos dessa classe. Todos os objetos compartilham
        - essa informação, que é TotalDeContasCriadas.
         */


        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _agencia = value;
            }
        }        

        public double Saldo // Por convenção o nome desse método se inicia com maiúscula.
        {
            get
            {
                return _saldo; // Poderia ser apenas saldo, pois não existe nem um argumento com esse mesmo nome
            }
            set
            {
                if (value < 0)
                {
                    return; // Return em um método com void, ele para a execução do bloco.                
                }
                else
                {
                    _saldo = value;
                }
                // Palavra reservada que funciona apenas nesse contexto: <value>.
            }
        }



        /*-----------------------------
        |   Método construtor
        |------------------------------
        */
        public ContaCorrente(int agencia, double numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++; // Não precisar chamar a classe quando se já esta dentro dela
            // ContaCorrente.TotalDeContasCriadas++; 
        }


        /*-----------------------------
        |   Função para subtrair um valor da conta da instância
        |------------------------------
        */
        public bool Sacar(double value)  // Utilzar sempre nomes no infinitivo
        {
            if (_saldo <= value) // this -> palavra reservada. O this acessa o saldo desta instancia
            {
                return false;
            }
            else
            {
                _saldo -= value;
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
            _saldo += value;

            return _saldo;
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

            if (_saldo < -100)
            {
                return false;
            }
            else
            {
                _saldo -= value;
                contaDestino.Depositar(value);

                return true;
            }
        }
    }
}
