using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    /// <summary>
    /// Classe para representar um Desenvolvedor (funcionário) do banco ByteBank. 
    /// </summary>
    class Developer : Employee
    {
        public Developer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Construtor da classe DEVELOPER.");
        }

        internal protected override double GetBonus()
        {
            return Wage * 0.1;
        }

        public override void WageIncrease()
        {
            Wage *= 1.15;
        }
    }
}
