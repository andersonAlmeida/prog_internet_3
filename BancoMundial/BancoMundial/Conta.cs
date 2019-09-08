using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    abstract class Conta
    {
        public Pessoa Titular { get; set; }

        public long Numero { get; set; }

        public int Agencia { get; set; }

        private double Saldo;

        private double TaxaSaque;

        public void Sacar(double valor) { }

        public double ConsultarSaldo()
        {
            return this.Saldo;
        }
        public void Transferir(Conta conta, double valor) { }
    }
}
