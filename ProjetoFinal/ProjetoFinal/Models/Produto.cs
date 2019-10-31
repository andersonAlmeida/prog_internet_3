using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public int Estoque { get; set; }
        public int Id_Marca { get; set; }
        public int Id_Categoria { get; set; }
    }
}
