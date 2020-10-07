using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
        }

        private static void CarregarContas()
        {
            /*------------------------------------
            |   using
            |------------------------------------
            *   A instrução <using> é usada para usar recursos e ter a certaza que estes recursos serão
            * liberados no fim do bloco da instrução using.
            */
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("LeitorDeContas.txt"))
            {
                leitor.LerProximaLinha();
            }



            //try
            //{
            //    leitor = new LeitorDeArquivos("LeitorDeContas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();                
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada");

            //}
            //finally {
            //    /* 
            //     * Server para informar o programador o final da execução da exceção, mesmo que não tenha gerado nem um erro no corpo do tryCatch
            //     * Será sempre executado, aconteça uma exceção ou não!
            //     * Será executado tanto com o try e tanto com catch.
            //    */

            //    if (leitor != null)
            //        leitor.Fechar();
            //}
        }
    }
}
