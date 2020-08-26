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
             *  A função das CallStack são:
             * Organizar a execução dos métodos e saber qual
             * método está sendo executado.
             */
            CurrentAccount conta = new CurrentAccount(32436659, 4987);

            try
            /*
             * O bloco try pode acompanhar vários blocos catch;
             */
            {
                Metodo();
            }
            /*
             * Exceções são objetos! Vamos acessar seus atributos.
             * Para isto, nomeie a referência para a exceção do tipo DivideByZeroException
             *  
             * Agora podemos visitar as propriedades desta exceção
             */
            catch (DivideByZeroException e)
            /*
             * Existe uma convenção para nomear as variáveis que fazem
             * referência a exceção do bloco catch
             * 
             * Para erro usadamos o <e>
             */
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            /*
             * Exception é a classe pai/base de todas as
             * exceções no C# e no .NET
             */

            /*
             *  Os blocos <catch> são visitados de cima para baixo,
             * nenhum bloco <catch> após o <catch> (Exception) será
             * executado, uma vez que esta captura todas as exceções no .NET.
             */

            /* 
             * O catch (Expetion) captura todas as exceções de C#, então
             *  se prevocarmos um exceção no bloco try, a mensagem Exceção
             *  captura e relança! será exibida.
             */
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            try
            {
                CurrentAccount account = new CurrentAccount(0, 0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu uma axceção do tipo ArgumentException");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
        


        static void Metodo()
        {
            TestaDivisao(0);
        }


        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }



        static int Dividir(int number, int divisor)
        {
            try
            {
                return number / divisor;
            }
            catch (DivideByZeroException)
            {                
                Console.WriteLine($"Erro ao dividir {number} por {divisor}");

                /*----------------------------------------
                 * throw -> lançando
                 *---------------------------------------- 
                 * 
                 *  Passa a exceção para adiante para alguém tratar ela.
                 *                  
                 */
                throw;                
            }            
        }
    }
}
