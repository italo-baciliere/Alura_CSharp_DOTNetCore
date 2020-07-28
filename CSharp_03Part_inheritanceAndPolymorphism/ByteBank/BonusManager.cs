using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class BonusManager
    {
        private double _bonusTotal;
        public void Register(Employee employee)
        {
            _bonusTotal += employee.GetBonificacao();
        }

        public void RegisterDirector(Director director)
        {
            _bonusTotal += director.GetBonificacao();
        }

        public double GetBonusTotal()
        {
            return _bonusTotal;
        }
    }
}
