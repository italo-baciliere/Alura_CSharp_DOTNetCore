using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Director : Employee
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salary { get; set; }

        public double GetBonificacao()
        {
            return Salary * 0.10;
        }
    }
}
