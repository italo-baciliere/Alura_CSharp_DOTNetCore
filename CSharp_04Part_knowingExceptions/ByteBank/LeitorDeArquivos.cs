using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBank
{
    class LeitorDeArquivos
    {



        public string Arquivo { get; }



        /*------------------------------
        | MÉTODO CONSTRUTOR
        |--------------------------------
        *
        */
        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;

            throw new FileNotFoundException();

            //Console.WriteLine("Abrindo arquivo: " + arquivo);
        }



        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";

            throw new IOException();
            /* Exceção definidade pelo DOT .NET
             * Eceção do tipo Input e Output
             */
        }



        public void Fechar()
        {
            Console.WriteLine("Fechando  arquivo.");
        }
    }
}
