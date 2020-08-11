using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    class Auxiliar : Employee
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }

        /*public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salary * 0.2;
        }*/
    }
}
