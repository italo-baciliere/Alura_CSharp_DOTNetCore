using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ByteBank.Employees
{
    public class AuthenticEmployee : Employee, IAuthentic
                                /* : Employee
                                Herdado a classe funcionário para continuar tendo todos os atributos */
    
    /*
     * Classe utilizada para que precisam ser funcionários 
     *  e precisa ser autenticado.
     */
    {
        public string Password { get; set; }

        public AuthenticEmployee(double salary, string cpf) : base (salary, cpf)
        {
        }

        public bool Authentic(string password)
        {
            return Password == password;
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }

        public override void IncreaseSalary()
        {
            throw new NotImplementedException();
        }
    }
}
