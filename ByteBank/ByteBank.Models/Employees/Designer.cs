using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    /// <summary>
    /// Classe para representar um Designer (funcionário) do banco ByteBank. 
    /// </summary>
    class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Construtor da classe DESIGNER.");
        }

        internal protected override double GetBonus()
        {
            return Wage * 0.17;
        }

        public override void WageIncrease()
        {
            Wage *= 1.11;
        }
    }
}
