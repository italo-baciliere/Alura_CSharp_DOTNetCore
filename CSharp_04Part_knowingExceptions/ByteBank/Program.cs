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
            LeitorDeArquivos leitor = null;

            try
            {
                leitor = new LeitorDeArquivos("LeitorDeContas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();                
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada");                
            }
            finally { // 13:25 Será sempre executado

                if (leitor != null)
                    leitor.Fechar();
            }
        }
    }
}
