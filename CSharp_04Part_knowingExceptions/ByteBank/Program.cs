using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------
             *  CallStack
             *----------------------------             
             * A função das CallStack são:
             *  Organizar a execução dos métodos e saber qual método está sendo executado.
             */
            CurrentAccount conta = new CurrentAccount(32436659, 4987);



            try
            {
                CurrentAccount conta3 = new CurrentAccount(4871, 9789465);
                CurrentAccount conta4 = new CurrentAccount(1384, 77773443);

                conta3.Transferir(10000, conta4);
            }
            catch (FinancialOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                
                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.Write(e.InnerException.Message);
                Console.Write(e.InnerException.StackTrace);
            }



            try
            {
                /*
                * O bloco try pode acompanhar vários blocos catch;
                */
                CurrentAccount account = new CurrentAccount(123, 5543);
                account.Saldo = 50;
                account.Sacar(1000);

                CurrentAccount account2 = new CurrentAccount(432, 63653);
                account2.Transferir(1000, account);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento: " + e.ParamName); // ParamName --> acessa o parametro nameof que causou a exceção
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine($"Saldo: {e.Balance}");
                Console.WriteLine($"Valor do saque: {e.WithdrawalAmount}");

                Console.WriteLine(e.StackTrace); // Rastro das pilhas de chamada, quem faz isso é a máquina virtual

                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // DivideByZeroException
            {
                /*
                * Exceções são objetos! Vamos acessar seus atributos.
                * Para isto, nomeie a referência para a exceção do tipo Exception
                * 
                * Agora podemos visitar as propriedades desta exceção
                *
                * Exception é a classe pai/base de todas as exceções no C# e no .NET
                *
                * Os blocos <catch> são visitados de cima para baixo,
                * nenhum bloco <catch> após o <catch> (Exception) será
                * executado, uma vez que esta captura todas as exceções no .NET.
                * 
                * O catch (Expetion) captura todas as exceções de C#, então
                *  se prevocarmos um exceção no bloco try, a mensagem Exceção
                *  captura e relança! será exibida.
                *
                * Existe uma convenção para nomear as variáveis que fazem
                * referência a exceção do bloco catch
                * 
                * Para erro usadamos o <e>
                */
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }            
        }          
    }
}
