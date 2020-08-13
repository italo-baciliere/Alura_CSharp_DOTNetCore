using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Systems
{
    class InternalSystem    
    {        
        /* 
         * Classe de verificação de autenticação de um IAuthentic       
         */
        public bool Login(IAuthentic employee, string password)
        {
            bool authenticatedUser = employee.Authentic(password);

            if (authenticatedUser)
            {
                Console.WriteLine("Welcome to System!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Password!");
                return false;
            }
        }
    }
}
