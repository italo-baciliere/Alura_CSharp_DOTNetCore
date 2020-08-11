﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Employee
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



        public virtual void IncreaseSalary()
        {            
            Salary *= 1.1;
        }
       


        /*
         Como quem desenvolve, esperamos que o acesso a uma propriedade seja imediato. 
        Ou seja, sem custo de processamento do computador, 
        no acesso de uma propriedade. O retorno de uma informação por meio de método não é de graça, 
        pois envolve um processamento em cima do dado e dentro do método até o retorno de um valor.

        Portanto, quando quisermos deixar claro que existe um processamento e que não é algo gratuito, 
        como o retorno de um campo
         */
        public virtual double GetBonificacao()
        /*-----------------
         *  VIRTUAL 
         *-----------------
         *  possibilita que uma classe filha e mais derivada, 
         *  mude o comportamento desse método
         *  
         *  Pode ser utilizado também nos métodos Get E Set.
         *  e.g: public virtual double Salary{ get; set;}
         */
        {
            return Salary * 0.10;   
        }

    }
}
