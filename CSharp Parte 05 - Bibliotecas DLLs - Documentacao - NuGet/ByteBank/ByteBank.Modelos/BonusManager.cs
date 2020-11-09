using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Employees;

namespace ByteBank.Modelos
{
    public class BonusManager
    {
        private double _bonusTotal;



        public void Register(Employee employee)
        {
            _bonusTotal += employee.GetBonificacao();
        }



        public double GetBonusTotal()
        {
            return _bonusTotal;
        }
    }
}
