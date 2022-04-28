using System;

namespace ByteBank
{
    /// <summary>
    /// Classe para representar uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class CheckingAccount
    {
        private Client _holder;
        private int _branch;
        private int _number;
        private double _balance = 0;

        public static int HandlingFee { get; private set; }
        public static int TotalCreatedAccounts { get; private set; }
        public int WithdrawsNotAllowedCounter { get; private set; }
        public int TransfersNotAllowedCounter { get; private set; }

        public Client Holder { get; set; }
        public int Branch { get; }
        public int Number { get; }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value;
            }
        }
        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="branch">Representa o valor da propriedade <see cref="Branch"/> e deve possuir um valor maior que zero.</param>
        /// <param name="number">Representa o valor da propriedade  <see cref="Number"/> e deve possuir um valor maior que zero.</param>
        public CheckingAccount(int branch, int number)
        {
            if (branch <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(branch));
            }

            if (number <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(number));
            }

            Branch = branch;
            Number = number;

            TotalCreatedAccounts++;
            HandlingFee = 30 / TotalCreatedAccounts;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Balance"/>.
        /// </summary>
        /// <param name="value">Representa o valor do saque, deve ser maior que 0 e menor que o <see cref="Balance"/>.</param>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="value"/>. </exception>
        /// <exception cref="InsufficientFundsException"> Exceção lançada quando o valor de <paramref name="value"/> é maior que o valor da propriedade <see cref="Balance"/>. </exception>
        public void Withdraw(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor de saque não pode ser negativo.", nameof(value));
            }
            if (_balance < value)
            {
                WithdrawsNotAllowedCounter++;
                throw new InsufficientFundsException(_balance, value);
            }
            _balance -= value;
        }
        /// <summary>
        /// Realiza uma transferência e atualiza o valor da propriedade <see cref="Balance"/>.
        /// </summary>
        /// <param name="value">Representa o valor da transferência, deve ser maior que 0 e menor que o <see cref="Balance"/>.</param>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="value"/>. </exception>
        /// <exception cref="FinancialTransactionException"> Exceção lançada quando ocorre um erro no método <see cref="Withdraw"/>. </exception>
        public bool Transferir(double value, CheckingAccount destinationAccount)
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(value));
            }
            try
            {
                Withdraw(value);
            }
            catch (InsufficientFundsException ex)
            {
                TransfersNotAllowedCounter++;
                throw new FinancialTransactionException("Operação não realizada.", ex);
            }
            destinationAccount.Deposit(value);
            return true;
        }

    }
}