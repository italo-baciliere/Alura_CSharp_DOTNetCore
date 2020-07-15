public class ContaCorrente
{
    public string titular;
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