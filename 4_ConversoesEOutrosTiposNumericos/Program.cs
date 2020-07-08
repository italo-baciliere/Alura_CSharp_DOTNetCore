using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o quarto projeto");

            double dotDouble = 0.3454345435435453435345;
            float  dotFloat  = 0.323535324f; // Possui uma menor precissão em relação ao Double, pois possui menos casas decimais
            Console.WriteLine("Double = " + dotDouble +
                ", Float = " + dotFloat);

            double salario = 1200.5;
            // int suporte valores de ate 32 bits
            int salarioEmInteiro = (int)salario; // Operação nomeada de <type casting>
            Console.WriteLine(salarioEmInteiro);

            // long é uma variavel de 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            /* short Suporta uma apenas valores menores.
            Total de 16 bits, resultando em no máximo 16000 mil */
            short quantidadeProdutos = 15000;
            Console.WriteLine("short = " + quantidadeProdutos);

            Console.ReadLine();
        }
    }
}
