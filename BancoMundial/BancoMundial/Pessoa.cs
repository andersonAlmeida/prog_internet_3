using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    abstract class Pessoa
    {
        public int NumeroDePessoas { get; set; }

        public int Id { get; set; }

        public string Endereco { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public Pessoa(int id, string endereco, string tel, string email) {
            this.Id = id;
            this.Endereco = endereco;
            this.Tel = tel;
            this.Email = email;
        }
    }
}
