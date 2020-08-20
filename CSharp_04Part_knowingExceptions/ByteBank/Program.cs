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
             *
             *  A função das CallStack são:
             * Organizar a execução dos métodos e saber qual
             * método está sendo executado.
             */
            CurrentAccount conta = new CurrentAccount(32436659, 4987);

            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            /*
             * Exceções são objetos! Vamos acessar seus atributos. Para isto, 
             *  nomeie a referência para a exceção do tipo DivideByZeroException
             *  
             * Agora podemos visitar as propriedades desta exceção
             */
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }                       
        }


        static int Dividir(int number, int divisor)
        {
            return number / divisor;
        }


        static void Metodo()
        {
            TestaDivisao(0);
        }


        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
