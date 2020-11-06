using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class CommercialPartnership : IAuthentic
    /*
     *-------------------------------
     * Parceiro Comercial
     * ------------------------------
     *      
     *  Required authentication, but not an Employee.
     * 
     */
    {
        public string Password { get; set; }

        public bool Authentic (string password)
        {
            return Password == password;
        }
    }
}
