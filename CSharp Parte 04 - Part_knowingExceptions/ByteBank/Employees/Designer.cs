using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    class Designer : Employee // Herança -> Director herda tudo que a classe Employee tem
                              // When instantiating a Director object, an Employee object is automatically instantiated.
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salary * 0.17;
        }
    }
}
