using System;
using System.Collections.Generic;
using System.Text;

namespace QuintoProjeto
{
    class Conta
    {
        public Cliente titular;
        public int agencia, conta;
        // privado, apenas essa classe tem acesso
        private double saldo;

        // nome de metodo começa letra maiuscula : CamelCase
        // metodo publico que não tem retorno
        public void Depositar( double valor )
        {
            this.saldo += valor;
        }

        // metodo para acessar o atributo privado saldo
        public double GetSaldo()
        {
            return this.saldo;
        }

        public bool Sacar( double valor )
        {
            if( this.saldo >= valor )
            {
                this.saldo -= valor;
                return true;
            }

            return false;
        }
    }
}
