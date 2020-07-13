using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoItalo = new ContaCorrente();/*Com a palavra new nós criamos um novo objeto do tipo especificado.
            Criação do uma classe na memória do computador*/
            // ContaCorrente é uma tipo de variável
            // contaDoItalo é uma objeto

            contaDoItalo.Titular = "Ítalo Baciliere";
            contaDoItalo.NumeroAgencia = 447;
            contaDoItalo.Numero = 863452;
            contaDoItalo.Saldo = 100;

            Console.WriteLine($"Titular :{contaDoItalo.Titular}");
            Console.WriteLine($"Número da Agência :{contaDoItalo.NumeroAgencia}");
            Console.WriteLine($"Número :{contaDoItalo.Numero}");
            Console.WriteLine($"Saldo :{contaDoItalo.Saldo}");

            contaDoItalo.Saldo += 200;
            Console.WriteLine("Novo Saldo:");
            Console.WriteLine($"Saldo :{contaDoItalo.Saldo}");
        }
    }
}
