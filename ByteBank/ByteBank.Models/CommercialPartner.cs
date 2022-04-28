using ByteBank.Models;
using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    /// <summary>
    /// Classe para representar um parceiro comercial do banco ByteBank. 
    /// </summary>
    public class CommercialPartner : IAuthenticable
    {
        private AutenticationHelper _autenticationHelper = new AutenticationHelper();
        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Autenticação do usuário
        /// </summary>
        /// <param name="password">senha informada pelo usuário para tentativa de autenticação</param>
        /// <returns></returns>
        public bool Authenticate(string password)
        {
            return _autenticationHelper.ComparePasswords(Password, password);
        }
    }
}
