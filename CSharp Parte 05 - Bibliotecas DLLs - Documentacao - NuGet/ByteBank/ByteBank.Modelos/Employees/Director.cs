using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Employees
{
    class Director : AuthenticEmployee
    {
        public string Password { get; set; }

        public Director(double salary, string cpf) : base(5000, cpf) // Placing the mouse over the base word Visual studio shows that we are using Employee.Employee(doubel salary, string cpf)
        // Dizemos que o construtor Diretor() vai chamar a base, passando um Salary and CPF.
        // reserved world <base> -> make reference to the base. In this case is Employee
        {
        }

        public bool
            Authentic(string password)
        {
            return Password == password;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }

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
         *      get {}
         *      set{}
         *  }
         */
        {
            return Salary * 0.5;
        }
    }
}
