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
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("LeitorDeContas.txt"))
            {
                leitor.LerProximaLinha();
            }                                             
        }
    }
}
