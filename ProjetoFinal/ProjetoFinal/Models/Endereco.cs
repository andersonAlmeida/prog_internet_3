using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Cep { get; set; }
        public string Logradouro{ get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Id_Proprietario { get; set; }
        public int Tipo { get; set; }
    }
}
