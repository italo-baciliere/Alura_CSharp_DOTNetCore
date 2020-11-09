using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Employees
{
    class Auxiliary : Employee
    {
        public Auxiliary(string cpf) : base(2000, cpf)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salary * 0.2;
        }
    }
}
