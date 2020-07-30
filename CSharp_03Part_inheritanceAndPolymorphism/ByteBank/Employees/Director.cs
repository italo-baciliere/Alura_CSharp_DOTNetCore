using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Director : Employee // Herança -> Director herda tudo que a classe Employee tem
    {        
        public override double GetBonificacao()
        /*-----------------
         *  OVERRIDE 
         *-----------------
         *  Em DireCtor, como utilizamos override, avisamos ao C#
         *  que sobrepomos a implementação da classe base e que,
         *  quando alguém trabalhar com a referência Diretor,
         *  ou com esse objeto a partir de uma referência do tipo Funcionario,
         *  o método a ser chamado é o GetBonificacao() de Diretor.
         *  
         *  Pode ser utilizado também nos métodos Get E Set.
         *  e.g: public override double Salary{ 
         *      get
         *      {
         *      }
         *      set
         *      {
         *      }
         *  }
         */
        {
            return Salary + base.GetBonificacao(); // reserved world <base> -> make reference to the base. In this case is Employee
        }
    }
}
