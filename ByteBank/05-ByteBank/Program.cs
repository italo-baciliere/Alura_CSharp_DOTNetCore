using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {                                    
            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Ítalo Baciliere";
            conta.titular.cpf = "089.323.234-04";
            conta.titular.profissao = "Dev C Sharp .Net Core";

            if (conta == null)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(conta.titular.nome);
            }                                    
        }
    }
}
