using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBank.Modelos
{
    class FileReader : IDisposable // Provides a mechanism for releasing unmanaged resources.
    {


        /*------------------------------
        | Variables
        |--------------------------------
        *
        */
        public string Arquivo { get; }



        /*------------------------------
        | MÉTODO CONSTRUTOR
        |--------------------------------
        *
        * Realizar a leitura de um arquivo
        * 
        */
        public FileReader(string arquivo)
        {
            Arquivo = arquivo;
        }



        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";

            throw new IOException();
        }



        public void Dispose()
        {
            Console.WriteLine("Fechando  arquivo.");
        }
    }
}
