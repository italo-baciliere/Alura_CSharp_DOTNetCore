using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {            

            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Ítalo Baciliere";
            conta.NumeroAgencia = 863;
            conta.Numero = 938203;
            conta.Saldo = 400;

            ContaCorrente conta2 = new ContaCorrente();

            conta2.Titular = "Ítalo Baciliere";
            conta2.NumeroAgencia = 274;
            conta2.Numero = 984882;
            conta2.Saldo = 540;

            Console.WriteLine($"Igualdade do tipo de referência: {conta == conta2}",conta,conta2); // return false

            int idade = 50;
            int idade2 = 50;

            Console.WriteLine($"Igualdade do tipo de valor: {idade == idade2}", idade, idade2); // return true

            conta = conta2;
                
            Console.WriteLine($"Igualdade do tipo de referência após referência uma objeto ao outro: {conta == conta2}", conta, conta2); // return true

            conta2.Saldo = 1000;

            Console.WriteLine("Resultado ao alterar uma conta reflete na outra!");
            Console.WriteLine(conta2.Saldo + "\r\n" + conta.Saldo);

            Console.ReadLine();
        }
    }
}
