using ByteBank.Employees;
using System;
using System.Text;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {                                                
            Console.ReadLine();
        }
    }



    public void CalcularBonificação()
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
    }
}
