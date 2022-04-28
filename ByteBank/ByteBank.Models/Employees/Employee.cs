using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    /// <summary>
    /// Classe abstrata para representar um funcionário do banco ByteBank. 
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Documento de identificação
        /// </summary>
        public string DocId { get; private set; }
        /// <summary>
        /// Salário do funcionário
        /// </summary>
        public double Wage { get; protected set; }
        /// <summary>
        /// Total de empregados
        /// </summary>
        public static int TotalEmployees { get; private set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="wage">Salário do funcionário</param>
        /// <param name="docId">Documento de identificação do funcionário</param>
        public Employee(double wage, string docId)
        {
            TotalEmployees++;
            DocId = docId;
            Wage = wage;
        }
        /// <summary>
        /// Retornar a bonificação do funcionário
        /// </summary>
        protected internal abstract double GetBonus();
        /// <summary>
        /// Aumentar o salário do funcionário
        /// </summary>
        public abstract void WageIncrease();
    }
}
