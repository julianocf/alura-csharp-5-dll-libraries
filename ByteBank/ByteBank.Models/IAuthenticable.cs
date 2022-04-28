using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Systems
{
    /// <summary>
    /// Interface para usuários autenticáveis
    /// </summary>
    public interface IAuthenticable
    {
        /// <summary>
        /// Método para autenticação do usuário
        /// </summary>
        /// <param name="password">Senha fornecida pelo usuário</param>
        /// <returns></returns>
        bool Authenticate(string password);
    }
}
