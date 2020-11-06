using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            InternalSystem internalSystem = new InternalSystem(); // Classe para realizarmos a verificação de authentication

            Director roberta = new Director(2500, "159.753.398-04");
            //roberta.Nome = "Roberta";
            roberta.Password = "Changeme";
            internalSystem.Login(roberta, "Changeme");
            internalSystem.Login(roberta, "ChangemE");

            AccountManager camila = new AccountManager("326.985.628-89");
            //camila.Nome = "Camila";
            camila.Password = "123@Mudar";
            internalSystem.Login(camila, "123@Mudar");
            internalSystem.Login(camila, "123@MUdar");

            Auxiliar igor = new Auxiliar("981.198.778-53");
            //igor.Nome = "Igor";                                      

            CommercialPartnership italo = new CommercialPartnership();
            italo.Password = "4567";

            internalSystem.Login(italo, italo.Password);
        }
    }
}
