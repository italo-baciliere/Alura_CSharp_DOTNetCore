using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            // Ao realizar essa ação o método Set e utilizado
            cliente.Nome = "Ítalo Baciliere";
            cliente.Profissao = "Dev C# .Net Core";
            cliente.CPF = "234.436.507-06";            
            
            ContaCorrente conta = new ContaCorrente();

            // Ao realizar essa ação o método Set e utilizado
            conta.Titular = cliente;                                    
            conta.NumeroAgencia = 7655;
            conta.Numero = 894388493;
            conta.Saldo = 100;

            // Ao realizar essa ação o método Get e utilizado
            Console.WriteLine(conta);
        }
    }
}
