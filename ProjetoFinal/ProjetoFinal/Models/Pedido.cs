using ProjetoFinal.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public double Total { get; set; }
        [DataType(DataType.Date)]
        public DateTime Prazo { get; set; }
        public int Id_Cliente { get; set; }
        public string Codigo_Rastreamento { get; set; }
        public PedidoStatus Status { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
