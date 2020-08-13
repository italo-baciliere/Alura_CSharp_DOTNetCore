using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Systems;

namespace ByteBank.Employees
{
    class AccountManager : AuthenticEmployee
    {


        public AccountManager(string cpf) : base(4000, cpf)
        /*
         * Aqui eu estou chamando o construtor 
         *  da classe Employee, passando assim
         *  dois os dois valores necessários
         * O salário aqui do Account Manager 
         *  já esta estipulado
         */
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salary * 0.25;
        }
    }
}
