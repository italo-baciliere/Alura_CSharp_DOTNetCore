
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_FirstPart_InitialSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------------------
            |   1 - Initial Steps
            |-----------------------------------------
            */
            Console.WriteLine("Executing the First Project - Initial Steps\r\n");
            Console.WriteLine("Hello World. Project on Visual Studio!");
            Console.ReadLine();



            /*-----------------------------------------
            |   2 - Creating Variables
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Secundo Project - Creating Variables\r\n");


            double salario = 1200.70;
            Console.WriteLine(salario);

            double idade = 15 / 20;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            Console.ReadLine();



            /*-----------------------------------------
            |   4 - Conversoes E Outros Tipos Numericos
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Fourth Project - Conversões e Outros Tipos Numéricos");

            double dotDouble = 0.3454345435435453435345;
            float dotFloat = 0.323535324f; // Possui uma menor precissão em relação ao Double, pois possui menos casas decimais
            Console.WriteLine("Double = " + dotDouble +
                ", Float = " + dotFloat);

            double vlrSalario = 1200.5;
            // int suporte valores de ate 32 bits
            int salarioEmInteiro = (int)vlrSalario; // Operação nomeada de <type casting>
            Console.WriteLine(salarioEmInteiro);

            // long é uma variavel de 64 bits
            long quantidade = 13000000000;
            Console.WriteLine(quantidade);

            /* short Suporta uma apenas valores menores.
            Total de 16 bits, resultando em no máximo 16000 mil */
            short quantidadeProdutos = 15000;
            Console.WriteLine("short = " + quantidadeProdutos);

            Console.ReadLine();



            /*-----------------------------------------
            |   5 - Caracters and Texts
            |-----------------------------------------
            */
            Console.WriteLine("Executando the Quinto Programa - Caracters and Texts!");


            // Manipulação de valores ASCII
            char firstLabel = 'a';
            Console.WriteLine(firstLabel);

            firstLabel = (char)62;
            Console.WriteLine(firstLabel);

            firstLabel = (char)(firstLabel + 1);
            Console.WriteLine(firstLabel);

            // Trabalhando com Strings
            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = // O uso do <@> faz com que a string seja exibida na forma que foi escrita
@"- .NET
- JAVA
- JavaScript.";

            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();



            /*-----------------------------------------
            |   6 - Assigning Variables
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Sixth Project - Assigning Variables");

            int vlrIdade = 32;
            int idadeItalo = vlrIdade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeItalo);


            Console.ReadLine();



            /*-----------------------------------------
            |   7 - Conditions
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Seventh Project - Conditions!");


            int idadeItaloBaciliere = 17;
            int idadeAcompanhante = 21;

            if (idadeItaloBaciliere >= 18)
            {
                Console.WriteLine("Entrada Permitida!");
            }
            else
            {
                if (idadeAcompanhante >= 21)
                {
                    Console.WriteLine("Entrada Permitida!");
                }
                else
                {
                    Console.WriteLine("Entrada Não Permitida!");
                }
            }


            Console.ReadLine();



            /*-----------------------------------------
            |   8 - Conditions 2
            |   9 - Escopo
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Eigth and Ninthe Project - Conditions!");

            
            int idadeLuciano = 17;
            int idadeCompanhia = 21;

            if (idadeItaloBaciliere >= 18 || idadeAcompanhante >= 21)
            {
                Console.WriteLine("Entrada Permitida!");
            }
            else
            {                
                Console.WriteLine("Entrada Não Permitida!");                
            }

            Console.ReadLine();



            /*-----------------------------------------
            |   10 - Calculate Savings
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Tenth Project - Calculate Savings!");


            double valorInvestido = 1000;
            int mes = 1;

            Console.WriteLine("Valor inicial investido: R$ " + valorInvestido);

            Console.WriteLine("------------------------------------" +
                              "\r\nValores rendidos a cada mês:"     +
                              "\r\n------------------------------------");                
            
            while (mes <= 12)
	        {
                // Ápos o rendimento
                valorInvestido += (valorInvestido * 0.0036);

                // Melhor formar de se escrever na tela com variavéis
                Console.WriteLine($"Valor após o rendimento dos mês {mes}: R$ {valorInvestido:F2}");
                mes++;

                /*Console.WriteLine("Valor após o rendimento dos mês "+ mes +": R$ " + valorInvestido.ToString("F2"));
                Console.WriteLine("Valor após o rendimento dos mês {0}: R$ {1}", mes, valorInvestido);*/               
	        }            

            Console.ReadLine();



            /*-----------------------------------------
            |   11 - Calculate Savings 2
            |-----------------------------------------
            */
            Console.WriteLine("Executing the Eleventh Project - Calculate Savings 2!");


            double valorInvestidoFor = 1000;
            int mesFor = 1;

            Console.WriteLine("Valor inicial investido: R$ " + valorInvestidoFor);

            Console.WriteLine("------------------------------------" +
                              "\r\nValores rendidos a cada mês:"     +
                              "\r\n------------------------------------");                
            
            for (; mesFor<=12; mesFor++)
	        {
                // Ápos o rendimento
                valorInvestidoFor += (valorInvestidoFor * 0.0036);

                // Melhor formar de se escrever na tela com variavéis
                Console.WriteLine($"Valor após o rendimento dos mês {mesFor}: R$ {valorInvestidoFor:F2}");                

                /*Console.WriteLine("Valor após o rendimento dos mês "+ mes +": R$ " + valorInvestido.ToString("F2"));
                Console.WriteLine("Valor após o rendimento dos mês {0}: R$ {1}", mes, valorInvestido);*/               
	        }            

            Console.ReadLine();
        }
    }
}