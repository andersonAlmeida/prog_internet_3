using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class ContaCorrente:Conta
    {
        private readonly string Tipo;

        private readonly double Limite;

        private readonly double TaxaDoLimite;

        public void Pagar(string codigoBarras)
        {

        }

        public void Emprestimo(double valor) { }

        public ContaCorrente(Pessoa titular, long numero, int agencia, double taxaSaque) { }
    }
}
