using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Sobrenome { get; set; }
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
