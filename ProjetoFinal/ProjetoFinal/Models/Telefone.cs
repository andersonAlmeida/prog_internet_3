using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Numero { get; set; }
        public int Id_Proprietario { get; set; }
        public int Tipo { get; set; }
    }
}
