using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
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

        public bool Authentic(string password)
        {
            return Password == password;
        }
    }
}