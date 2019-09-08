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

        public virtual void Sacar(double valor) {
            this.Saldo -= valor + this.TaxaSaque; 
        }

        public double ConsultarSaldo()
        {
            return this.Saldo;
        }
        public void Transferir(Conta conta, double valor) { }

        public Conta(Pessoa titular, long numero, int agencia, double taxaSaque) {
            this.Titular = titular;
            this.Numero = numero;
            this.Agencia = agencia;
            this.TaxaSaque = taxaSaque;

            this.Saldo = 0.0;
        }

        public void SetSaldo(double valor)
        {
            this.Saldo += valor;
        }

        public void SetTaxaSaque(double valor)
        {
            this.TaxaSaque = valor;
        }

        public abstract void Transferencia(Conta credito, double valor);

    }
}
