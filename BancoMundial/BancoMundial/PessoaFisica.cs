using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public class PessoaFisica: Pessoa
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNasc { get; set; }

        private readonly int Idade;

        private readonly string FaixaEtaria;

        public double Renda { get; set; }

        public PessoaFisica(
            int id, string endereco, string tel, string email,
            string nome, string sobrenome, string rg, string cpf, DateTime dataNasc):base(id, endereco, tel, email)
        {
            Auxiliar aux = new Auxiliar();

            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.DataNasc = dataNasc;
            this.Idade = aux.CalculaIdade(dataNasc);
            this.FaixaEtaria = aux.FaixaEtaria(this.Idade);
            
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public string GetFaixaEtaria()
        {
            return this.FaixaEtaria;
        }

        
    }
}
