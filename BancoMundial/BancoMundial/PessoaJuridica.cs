using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class PessoaJuridica: Pessoa
    {
        public ArrayList Socios = new ArrayList();

        public int Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public int InscrEstadual { get; set; }

        public DateTime DataAbertura { get; set; }

        private readonly int Idade;

        public double Faturamento { get; set; }

        public PessoaJuridica(
            int id, string endereco, string tel, string email,
            ArrayList socios, int cnpj, string razaoSocial, string nomeFantasia,
            int inscrEstadual, DateTime dataAbertura):base(id, endereco, tel, email) {

            this.Socios = socios;
            this.Cnpj = cnpj;
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
            this.InscrEstadual = inscrEstadual;
            this.DataAbertura = dataAbertura;
        }


    }
}
