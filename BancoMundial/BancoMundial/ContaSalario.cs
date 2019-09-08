using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class ContaSalario:Conta
    {
        public ContaSalario(
            Pessoa titular, long numero, int agencia, double taxaSaque):base(titular, numero, agencia, taxaSaque) {

            this.Titular = titular;
            this.Numero = numero;
            this.Agencia = agencia;
            this.SetTaxaSaque(0.0);
            
        }

        public override void Sacar(double valor)
        {
            double saldo = this.ConsultarSaldo();

            if (saldo - valor >= 0)
            {
                base.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Você não possuí saldo suficiente para completar a operação.");
            }
        }

        public override void Transferencia(Conta credito, double valor)
        {
            if (this.Titular.Id == credito.Titular.Id)
            {
                double saldo = this.ConsultarSaldo();

                if (saldo - valor >= 0)
                {
                    this.SetSaldo(valor * -1);
                    credito.SetSaldo(valor);
                }

            }
        }
    }
}
