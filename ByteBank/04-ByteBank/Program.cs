using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoItalo = new ContaCorrente();

            contaDoItalo.saldo = 300;
            bool result = contaDoItalo.Sacar(400);
            Console.WriteLine(result);
            
            double resultDepos = contaDoItalo.Depositar(200);
            Console.WriteLine(resultDepos);

            result = contaDoItalo.Sacar(400);
            Console.WriteLine(result);


            ContaCorrente contaDaGabi = new ContaCorrente();
            contaDaGabi.titular = "Gabriela";
            contaDaGabi.saldo = 200;
            Console.WriteLine($"Saldo conta da Gabi: {contaDaGabi.saldo}");
            contaDaGabi.Transferir(100, contaDoItalo);
            Console.WriteLine($"Saldo conta da Gabi: {contaDaGabi.saldo}");


            Console.Read();
        }
    }
}
