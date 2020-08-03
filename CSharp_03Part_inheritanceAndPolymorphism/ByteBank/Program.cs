using ByteBank.Employees;
using System;
using System.Text;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusManager bonusManager = new BonusManager();            
            

            Employee italo = new Employee(2100.00, "333.443.252-19");            
            italo.Name = "Ítalo";                        
            bonusManager.Register(italo);
            Console.WriteLine(italo.GetBonificacao());
            

            Director Roberta = new Director(4000.00, "453.777.452-65");
            Roberta.Name = "Roberta";                        
            bonusManager.Register(Roberta);
            Console.WriteLine(Roberta.GetBonificacao());
            

            Console.WriteLine($"Total de Bonus: {bonusManager.GetBonusTotal()}");            
                        

            Console.ReadLine();
        }
    }
}
