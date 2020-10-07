using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBank
{
    class LeitorDeArquivos : IDisposable // objetos especificados no bloco using devem implementar a interface IDisposable
        // Provides a mechanism for releasing unmanaged resources. // Método que libera os recursos
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

            throw new FileNotFoundException(); // A exceção que é gerada quando ocorre falha na tentativa de acessar um arquivo que não existe no disco.            
        }



        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do arquivo";

            throw new IOException(); // The exception that is thrown when an I/O error occurs
            /* Exceção definidade pelo DOT .NET
             * Eceção do tipo Input e Output
             */
        }



        public void Dispose() // Provides a mechanism for releasing unmanaged resources. // Método que libera os recursos
            // using confere se a instância é nula e depois chama o dispose
            // Using sempre chamará o Dispose
        {
            Console.WriteLine("Fechando  arquivo.");
            throw new NotImplementedException();
        }
    }
}


// ---------------------------------------------------------------------------------------------------
/*-------------------------
 * ------------------------
 * Estudar o using: http://www.macoratti.net/20/02/c_using1.htm
 * Pesquisar e estudor sobre o idisposable c#
 */

// Caso onde a referência é nula
// No caso onde da tudo certo e o Dispode é executado
// No caso onde a referência não é nula, mas dentro no bloco using conteceu uma exceção.