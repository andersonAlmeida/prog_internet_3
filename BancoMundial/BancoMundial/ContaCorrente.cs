using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class ContaCorrente:Conta, Depositavel
    {
        private readonly string Tipo;

        private readonly double Limite;

        private readonly double TaxaDoLimite;

        private double Renda;

        public void Pagar(string codigoBarras)
        {

        }

        public void Emprestimo(double valor) { }

        public ContaCorrente(
            double renda,
            Pessoa titular, long numero, int agencia, double taxaSaque):base(titular, numero, agencia, taxaSaque)
        {            
            this.Renda = renda;

            if (renda > 5000.00)
            {
                this.Tipo = "ESPECIAL";
                this.Limite = renda * -2.5;
                this.TaxaDoLimite = renda * 0.2;
            }
            else
            {
                this.Tipo = "SIMPLES";
                this.Limite = renda * -1.5;
                this.TaxaDoLimite = renda * 0.5;
            }

            this.Titular = titular;
            this.Numero = numero;
            this.Agencia = agencia;
            this.SetTaxaSaque(taxaSaque);
        }

        public override void Sacar(double valor)
        {
            double saldo = this.ConsultarSaldo();

            if (saldo - valor >= this.Limite)
            {
                base.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Você não possuí saldo suficiente para completar a operação.");
            }
        }

        public void Depositar(double valor)
        {
            this.SetSaldo(valor);
        }

        public override void Transferencia(Conta credito, double valor)
        {
            double saldo = this.ConsultarSaldo();

            if (saldo - valor >= this.Limite)
            {
                this.SetSaldo(valor * -1);
                credito.SetSaldo(valor); 
            }
            else
            {
                Console.WriteLine("Você não possuí saldo suficiente para completar a operação.");
            }
        }
    }
}
