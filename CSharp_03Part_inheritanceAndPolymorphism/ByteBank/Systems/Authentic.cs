using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Employees;

namespace ByteBank.Systems
{
    abstract class Authentic : Employee // Herdado a classe funcionário para continuar tendo todos os atributos
    // Classe para funcionários que serão validados no sistema
    {
        public string Password { get; set; }
        
        public Authentic(double salary, string cpf) : base(salary, cpf) // Constructor Method
        { }

        public bool Authenticate(string password) // Verificação de autenticação
        {
            return Password == password;
        }
    }
}
