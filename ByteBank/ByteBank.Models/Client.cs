using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    /// <summary>
    /// Classe para representar um cliente do banco ByteBank. 
    /// </summary>
    public class Client
    {
        private string _name;
        private string _idDoc;
        private string _profession;
        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Documento de identidade
        /// </summary>
        public string IdDoc { get; set; }
        /// <summary>
        /// Profissão
        /// </summary>
        public string Profession { get; set; }

    }
}
