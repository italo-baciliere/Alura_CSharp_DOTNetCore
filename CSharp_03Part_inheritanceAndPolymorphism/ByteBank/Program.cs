using ByteBank.Employees;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {           
            Employee italo = new Employee();
            BonusManager bonusManager = new BonusManager();

            italo.Name = "Ítalo";
            italo.CPF = "333.443.252-19";
            italo.Salary = 2100.00;

            bonusManager.Register(italo);
            Console.WriteLine(italo.GetBonificacao());

            Director Roberta = new Director();
            Roberta.Name = "Roberta";
            Roberta.CPF = "453.777.452-65";
            Roberta.Salary = 4000.00;

            bonusManager.RegisterDirector(Roberta);
            Console.WriteLine(Roberta.GetBonificacao());

            Console.ReadLine();

        }
    }
}
