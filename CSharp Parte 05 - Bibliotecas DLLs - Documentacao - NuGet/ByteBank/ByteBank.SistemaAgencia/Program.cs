using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount conta = new CurrentAccount(432, 2124);
            Console.WriteLine(conta.Agencia);
            Console.ReadLine();
        }
    }
}