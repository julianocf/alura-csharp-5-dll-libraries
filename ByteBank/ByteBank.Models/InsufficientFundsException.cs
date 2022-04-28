using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    /// <summary>
    /// Exceção para tratar erros referentes a falta de saldo nas contas dos clientes
    /// </summary>
    class InsufficientFundsException : Exception
    {
        public double Balance { get; }
        public double WithdrawAmmount { get; }
        public InsufficientFundsException(double balance, double withdrawAmmount)
            : this("Tentativa de saque de " + withdrawAmmount + " com saldo de " + balance)
        {
            Balance = balance;
            WithdrawAmmount = withdrawAmmount;
        }
        public InsufficientFundsException()
        {

        }
        public InsufficientFundsException(string message)
            : base(message)
        {

        }
        public InsufficientFundsException(string message, Exception internalException)
            : base(message, internalException)
        {

        }
    }
}
