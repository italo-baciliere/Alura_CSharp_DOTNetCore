//using _05_ByteBank; //Não é preciso importar o namespace porque esse arquivo ja faz parte dele

namespace _05_ByteBank
{
    public class ContaCorrente
    {        

        public Cliente titular;
        public int numeroAgencia;
        public int numero;
        public double saldo;        

        /*-----------------------------
        |   Função para subtrair um valor da conta da instância
        |------------------------------
        */
        public bool Sacar(double value)  // Utilzar sempre nomes no infinitivo
        {
            if (this.saldo <= value) // this -> palavra reservada. O this acessa o saldo desta instancia
            {
                return false;
            }
            else
            {
                this.saldo -= value;
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
            this.saldo += value;

            return this.saldo;
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

            if (this.saldo < -100)
            {
                return false;
            }
            else
            {
                this.saldo -= value;
                contaDestino.Depositar(value);

                return true;
            }
        }
    }
}