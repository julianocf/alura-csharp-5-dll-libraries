using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models
{
    /// <summary>
    /// Classe Helper para as autenticações do sistema
    /// </summary>
    internal class AutenticationHelper
    {
        /// <summary>
        /// Compara duas senhas e retorna se a senha informada é válida
        /// </summary>
        /// <param name="truePassword">A senha correta</param>
        /// <param name="inputPassword">A senha que o usuário informou</param>
        /// <returns></returns>
        public bool ComparePasswords(string truePassword, string inputPassword)
        {
            return truePassword == inputPassword;
        }
    }
}
