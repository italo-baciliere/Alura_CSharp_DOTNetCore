using ByteBank.Employees;
using ByteBank.Systems;
using System;
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
            internalSystem.Loginto(roberta, "Changeme");
            internalSystem.Loginto(roberta, "ChangemE");

            AccountManager camila = new AccountManager("326.985.628-89");
            //camila.Nome = "Camila";
            camila.Password = "123@Mudar";
            internalSystem.Loginto(camila, "123@Mudar");
            internalSystem.Loginto(camila, "123@MUdar");

            Auxiliar igor = new Auxiliar("981.198.778-53");
            //igor.Nome = "Igor";                                      
            
        }
    }



    /*public void CalcularBonificação()
    {
        BonusManager bonusManager = new BonusManager();                


        Designer pedro = new Designer("833.222.048-39");
        pedro.Nome = "Pedro";

        Director roberta = new Director("159.753.398-04");
        roberta.Nome = "Roberta";

        Auxiliar igor = new Auxiliar("981.198.778-53");
        igor.Nome = "Igor";

        AccountManager camila = new AccountManager("326.985.628-89");
        camila.Nome = "Camila";
    }*/
}
