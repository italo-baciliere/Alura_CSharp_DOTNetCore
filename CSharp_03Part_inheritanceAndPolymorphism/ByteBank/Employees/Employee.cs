using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Employee
    {        
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salary { get; set; }
        
        /*
         Como quem desenvolve, esperamos que o acesso a uma propriedade seja imediato. 
        Ou seja, sem custo de processamento do computador, 
        no acesso de uma propriedade. O retorno de uma informação por meio de método não é de graça, 
        pois envolve um processamento em cima do dado e dentro do método até o retorno de um valor.

        Portanto, quando quisermos deixar claro que existe um processamento e que não é algo gratuito, 
        como o retorno de um campo
         */
        public double GetBonificacao()
        {            
            return Salary * 0.10;
        }

    }
}
