using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBank
{
    class LeitorDeArquivos : IDisposable     
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
        public LeitorDeArquivos(string arquivo)
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
