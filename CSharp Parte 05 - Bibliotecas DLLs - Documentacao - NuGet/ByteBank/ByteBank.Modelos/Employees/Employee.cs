using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Employees
{

    /*-----------------
         *  VIRTUAL 
         *-----------------
         *  possibilita que uma classe filha e mais derivada, 
         *  mude o comportamento desse método
         *  
         *  Pode ser utilizado também nos métodos Get E Set.
         *  e.g: public virtual double Salary{ get; set;}
    */

    public abstract class Employee
    /* Uma classe abstrata não pode ser instanciada.
     * A finalidade de uma classe abstrata é fornecer 
     *  uma definição comum de uma classe base que pode 
     *  ser compartilhada por várias classes derivadas.
     * Por exemplo, uma biblioteca de classes pode definir
     *  uma classe abstrata que serve como um parâmetro para 
     *  muitas de suas funções e exige que os programadores 
     *  que usam essa biblioteca forneçam sua própria implementação 
     *  da classe, criando uma classe derivada.
     */
    {
        public static int TotalEmployees { get; private set; } // Use o modificador static para declarar um membro estático que pertença ao próprio tipo, em vez de um objeto específico.

        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Salary { get; protected set; } // Permite o acesso para classes derivadas



        /*--------------------------
        |* Método Construtor
        |---------------------------
        */
        public Employee(double salary, string cpf)
        {
            Salary = salary;
            CPF = cpf;
            TotalEmployees++; // Contador de quantidade de funcionários.
        }



        public abstract void IncreaseSalary();



        /*
         Como quem desenvolve, esperamos que o acesso a uma propriedade seja imediato. 
        Ou seja, sem custo de processamento do computador, 
        no acesso de uma propriedade. O retorno de uma informação por meio de método não é de graça, 
        pois envolve um processamento em cima do dado e dentro do método até o retorno de um valor.

        Portanto, quando quisermos deixar claro que existe um processamento e que não é algo gratuito, 
        como o retorno de um campo
         */
        public abstract double GetBonificacao();
    }
}
