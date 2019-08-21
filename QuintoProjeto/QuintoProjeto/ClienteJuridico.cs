using System;
using System.Collections.Generic;
using System.Text;

namespace QuintoProjeto
{
    class ClienteJuridico : Cliente
    {
        public string Cnpj { get; set; }

        public ClienteJuridico()
        {
        }

        public ClienteJuridico(string cnpj)
        {
            Cnpj = cnpj;
        }
    }
}
