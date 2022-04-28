using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    /// <summary>
    /// Classe para representar um Gerente de Contas (funcionário) do banco ByteBank. 
    /// </summary>
    class AccountManager : AuthenticableEmployee
    {
        public AccountManager(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Construtor da classe ACCOUNTMANAGER.");
        }

        internal protected override double GetBonus()
        {
            return Wage * 0.25;
        }

        public override void WageIncrease()
        {
            Wage *= 1.05;
        }

    }
}
