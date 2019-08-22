using System;
using System.Collections.Generic;
using System.Text;

namespace QuintoProjeto
{
    /* ClienteFisico (extende/herda de) Cliente
     */
    class ClienteFisico : Cliente
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public double Renda { get; set; }

        public ClienteFisico()
        {
        }

        public ClienteFisico(string cpf, string rg, double renda)
        {
            Cpf = cpf;
            Rg = rg;
            Renda = renda;
        }

        /* A palavra OVERRIDE indica que você está sobreescrevendo
         * um método VIRTUAL
         */
        public override string GetInfo()
        {
            return "Nome: " + Nome + "\nCPF: " + Cpf;
        }
    }
}
