using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    /// <summary>
    /// Classe para totalizar as bonificações dos funcionários
    /// </summary>
    class BonusManager
    {
        private double _totalBonus;

        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}
