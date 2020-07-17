using System;

namespace CSharp_parte2___Introducao_a_Orientacao_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* INSTÂNCIA DE OBJETOS */

            /*
            * Com a palavra new nós criamos um NOVO OBJETO do tipo especificado.
            * Criação do uma classe na MEMÓRIA VIRTUAL.
            */
            ContaCorrente conta = new ContaCorrente(2504, 8255445);
            /* 
             * ContaCorrente é uma tipo de VARIÁVEL
             * contaDoItalo é uma OBJETO
            */



            /* REFERÊNCIA DE OBJETOS */

            ContaCorrente conta2 = new ContaCorrente(5590, 80738830);
            ContaCorrente conta3 = new ContaCorrente(2390, 81935370);

            Console.WriteLine($"Igualdade do tipo de referência ao comparar dois objetos do mesmo tipo: " +
                $"{conta2 == conta3}", conta2, conta3); // return false

            int idade = 50;
            int idade2 = 50;

            Console.WriteLine($"Igualdade do tipo de valor ao compara duas variáveis: " +
                $"{idade == idade2}", idade, idade2); // return true

            conta2 = conta3;

            Console.WriteLine($"Igualdade do tipo de referência após setar um objeto ao outro: " +
                $"{conta2 == conta3}", conta2, conta3); // return true

            conta2.Saldo = 1000;

            Console.WriteLine("Ao alterar uma conta é refletido na outra!");
            Console.WriteLine(conta2.Saldo + "\r\n" + conta3.Saldo);



            /* USO DE FUNÇÕES */

            conta2.Saldo = 500;
            Console.WriteLine("Resultado ao utilizar a função de saque da classe ContaCorrente: " +
                conta2.Sacar(400));

            Console.WriteLine("Resultado ao utilizar a função de deposito da classe ContaCorrente: " +
                conta2.Depositar(400));

            Console.WriteLine("Resultado ao utilizar a função de transferir da classe ContaCorrente: " +
                conta2.Transferir(400, conta3));

            Console.WriteLine("Total de contas criadas: " +
                ContaCorrente.TotalDeContasCriadas);



            /* MÉTODOS GET E SET */

            Cliente cliente = new Cliente();

            // Ao realizar essa ação o método Set e utilizado
            cliente.Nome = "Ítalo Baciliere";
            cliente.Profissao = "Dev C# .Net Core";
            cliente.CPF = "234.436.507-06";

            ContaCorrente conta4 = new ContaCorrente(2344, 82440939);

            // Ao realizar essa ação o método Set e utilizado
            conta.Titular = cliente;
            conta.Agencia = 7655;
            conta.Numero = 894388493;
            conta.Saldo = 2000;

            // Ao realizar essa ação o método Get e utilizado
            Console.WriteLine(conta);
        }
    }
}
